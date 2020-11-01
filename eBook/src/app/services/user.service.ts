import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../user.model';
import { USERS } from '../users';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  private userUrl = "https://localhost:44375/api/user";

  users : User[] = USERS;
 

  user : User = {
    id : 0,
    firstname: "",
    lastname: "",
    email: "",
    password: "",
    address: "",
    isAdmin: false
  }
  constructor(private http: HttpClient) { }
 
  addUser(user : User) : Observable<User>{
    try {
      const url = `${this.userUrl}/add`;
      return this.http.post<User>(url, user, this.httpOptions);
    } catch (err) {
      console.error(err.message);
    }
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
