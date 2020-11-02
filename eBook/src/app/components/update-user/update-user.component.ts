import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { error } from 'protractor';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/app/user.model';

@Component({
  selector: 'app-update-user',
  templateUrl: './update-user.component.html',
  styleUrls: ['./update-user.component.scss']
})
export class UpdateUserComponent implements OnInit {
  @Input() click : boolean;
  @Output() eventEmitter = new EventEmitter<boolean>(); 

  user : User = {
    id : 0,
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    address: "",
    isAdmin:false
  };
  password2 : string;
  password3 : string;

  constructor(public userService : UserService) { }

  ngOnInit(): void {
  }

  onSubmit(){
    this.user.id = this.userService.user.id;
    this.setPasswords();
    this.userService.updateUser(this.user)
    .subscribe(user => this.userService.user = user, error => console.log(error));
  }

  update(value : boolean){
    this.onSubmit();
    this.eventEmitter.emit(value);
  }

  setPasswords(){
    if(this.password2 == this.password3){
      this.user.password = this.password2;
    }else {
      console.log("your password do not match");
      this.password2 = "";
      this.password3 = "";
    }
  }
}
