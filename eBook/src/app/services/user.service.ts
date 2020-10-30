import { Injectable } from '@angular/core';
import { User } from '../user.model';
import { USERS } from '../users';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  users : User[] = USERS;

  user : User = {
    id : 0,
    picture: "",
    firstname: "",
    lastname: "",
    email: "",
    password: "",
    books: [],
    orders: []
  }
  constructor() { }
 
  addUser(firstname, lastname, email, password){
    this.user.firstname = firstname;
    this.user.lastname = lastname;
    this.user.email = email;
    this.user.password = password;
  }
  logIn(email, password){
    this.users.forEach(user => {
      if(user.email == email && user.password == password){
        this.user = user;
        console.log(this.user);
      }
    });
  }
}
