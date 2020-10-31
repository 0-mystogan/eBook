import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from '../book.model';
import { BOOKS } from '../books';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  private booksUrl = "https://localhost:44375/api/book";

  constructor(private http: HttpClient) { }

  getBooks(): Observable<Book[]> {
    const url = `${this.booksUrl}/get`
    return this.http.get<Book[]>(url);
  }

  getBook(id: number): Observable<Book> {
    const url = `${this.booksUrl}/getbyid/${id}`;
    return this.http.get<Book>(url);
  }
}
