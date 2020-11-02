import { Component, OnInit } from '@angular/core';
import { error } from 'console';
import { UseExistingWebDriver } from 'protractor/built/driverProviders';
import { MessageService } from 'src/app/services/message.service';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/app/user.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  user : User = {
    id : 0,
    firstname: "",
    lastname: "",
    email: "",
    password: "",
    address: "",
    isAdmin:false
  };
  password2 : string;

  constructor(private userService : UserService, private messageService : MessageService) { }

  ngOnInit(): void {
  } 
  onSubmit(){
    if(this.validateUser(this.user)){
      this.userService.addUser(this.user).subscribe(user => this.userService.user = user.user, error => console.log(error));
    }else {
      console.log("Niste unijeli sve podatke");
    }
    
  }

  validateUser(user : User) : boolean{
    if(user.firstName == "" || user.lastName == "" || user.email == "" || user.password == "" || user.address == "")
      return false;
      else return true; 
  }
}
