import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  click : boolean;

  constructor(public userService : UserService) { }

  ngOnInit(): void {
  }
  openForm(value : boolean){
    this.click = value;
  }
  logOut(){
    this.userService.user = null;
  }
}
