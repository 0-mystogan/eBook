import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../user.model';
import { UserLogin } from '../userlogin.model';
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
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    address: "",
    isAdmin: false
  }

  userr : User;

  userlogin : UserLogin = {
    email : "",
    password : ""
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

  logIn(user : UserLogin) : Observable<User>{
    try {
      const url = `${this.userUrl}/login`;
      return this.http.post<User>(url, user, this.httpOptions);
    } catch (err) {
      console.error(err.message);
    }
  }
}
