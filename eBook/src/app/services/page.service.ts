
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Page } from '../page.model';
  
@Injectable({
   providedIn: 'root'
 })


  export class PageService{
   constructor(private http: HttpClient) { }
   

   pageUrl : string = "https://localhost:44375/api/user/getall?pageNumber=1&pageSize=10";

   getPageUsers() : Observable<Page>{
      try {
        const url = this.pageUrl;
        return this.http.get<Page>(url);
      } catch (err) {
        console.error(err.message);
      }    
    }
  }
  