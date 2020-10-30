import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  @Input() click : boolean;
  @Output() eventEmitter = new EventEmitter<boolean>(); 

  email : string;
  password : string;

  constructor(private userService : UserService) { }

  ngOnInit(): void {
  }
  logIn(value : boolean){
    console.log(value);
    this.eventEmitter.emit(value);
    this.userService.logIn(this.email, this.password);
  }
}
