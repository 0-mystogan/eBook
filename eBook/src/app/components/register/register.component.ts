import { Component, OnInit } from '@angular/core';
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
  firstname : string;
  lastname : string;
  email : string;
  password : string;
  password2 : string;

  constructor(private userService : UserService, private messageService : MessageService) { }

  ngOnInit(): void {
  } 
  onSubmit(){
   this.userService.addUser(this.firstname, this.lastname, this.email, this.password)
   
   console.log(this.userService.user.email);
  }
}
