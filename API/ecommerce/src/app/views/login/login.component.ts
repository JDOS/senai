import { Component } from '@angular/core';
import { User } from 'src/app/model/user';
import { LoginService } from 'src/app/services/login.service';
// import para redirecionamento
import {Router} from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  
  constructor(private loginService:LoginService, private router:Router){}  
  
  userModel = new User();

  mensagem = ""
  
  receberDados(){
    console.log(this.userModel)

    // Blacklist
    const listaPalavras: string[] = ["select ", 
    "from ",
     "drop ",
      "delete ",
       "or ", 
       "update ", 
       "having ",
        "group ", 
        "by ",
         "insert ",
          "exec ",
          "\"",
          "\'",
          "--", 
          "#",
    ";"]

    listaPalavras.forEach(palavra =>{
      if(this.userModel.email?.toLowerCase().includes(palavra)){
        this.mensagem = "Dados inválidos " + palavra
        // finaliza a requisição
        return;
      }
    });

    this.loginService.login(this.userModel).subscribe((response) => {
      console.log("Sucesso!")
      localStorage.setItem("nomeUsuario", response.body.user.nome)
      this.router.navigateByUrl("/")  
    
    }, (erro) => {
      console.log("ERROR")
      // alert(erro.error)
      this.mensagem=erro.error
    })  
  }
}
