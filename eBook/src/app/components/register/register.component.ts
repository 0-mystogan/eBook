import { Component, OnInit } from '@angular/core';
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
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    address: "",
    isAdmin:false,
    image: ""
  };
  password2 : string;

  constructor(private userService : UserService) { }

  ngOnInit(): void {
  } 
  onSubmit(){
    if(this.validateUser(this.user)){
      this.userService.addUser(this.user).subscribe(user => this.userService.user = user, error => console.log(error));
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
