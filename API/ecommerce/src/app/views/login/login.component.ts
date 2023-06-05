import { Component } from '@angular/core';
import { User } from 'src/app/model/user';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  
  constructor(private loginService:LoginService){}  
  
  userModel = new User();
  
  receberDados(){
    console.log(this.userModel)


    this.loginService.login(this.userModel).subscribe((response) => {
      console.log(response.body.user.nome)
    })
  }
}
