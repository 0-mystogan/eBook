import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { UseExistingWebDriver } from 'protractor/built/driverProviders';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/app/user.model';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  user: User;
  isLogedIn: boolean = true;
  name : string = this.userService.user.firstName;

  constructor(public userService: UserService) {
  }

  ngOnInit(): void {
  }
}
