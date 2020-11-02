import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { error } from 'protractor';
import { UserService } from 'src/app/services/user.service';
import { UserLogin } from 'src/app/userlogin.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  @Input() click : boolean;
  @Output() eventEmitter = new EventEmitter<boolean>(); 

 user : UserLogin = {
   email : "",
   password : ""
 }

  constructor(private userService : UserService) { }

  ngOnInit(): void {
  }

   onSubmit(){
   this.userService.logIn(this.user).subscribe(user  => {
    this.userService.user = user;
    },
      error => console.error(error));
   
  }

  logIn(value : boolean){
    this.onSubmit();
    this.eventEmitter.emit(value);
  }

}
  
