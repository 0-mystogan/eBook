import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  click : boolean;
  constructor(public userService : UserService) { }

  ngOnInit(): void {
  }

  openForm(value : boolean){
    this.click = value;
  }
  
  clickUser(){
    console.log(this.userService.user);
  }
}
