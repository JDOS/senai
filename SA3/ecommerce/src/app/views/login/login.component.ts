import { Component } from '@angular/core';
import { User } from 'src/app/model/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  userModel = new User();
  receberDados(){
    console.log(this.userModel)
  }
}
