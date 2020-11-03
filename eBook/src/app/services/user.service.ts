import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../user.model';
import { UserLogin } from '../userlogin.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  private userUrl = "https://localhost:44375/api/user";

  user : User = {
    id : 0,
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    address: "",
    isAdmin: false,
    image: ""
  }

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

  updateUser(user : User) : Observable<User>{
    try {
      const url = `${this.userUrl}/update`;
      return this.http.put<User>(url, user);
    } catch (err) {
      console.log(err.message);
    }
  }
  upadageImg(user : User) : Observable<User>{
    try {
      const url = `${this.userUrl}/updateimg`;
      return this.http.put<User>(url, user);
    } catch (err) {
      console.error(err.message);
    }
  }

  uploadProfileImage(files: any): Observable<any> {
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);

    const url = `${this.userUrl}/upload`;

    return this.http.post(url, formData, {reportProgress: true, observe: 'events'});
  }
}
