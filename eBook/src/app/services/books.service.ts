import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Book } from '../book.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  private booksUrl = "https://localhost:44375/api/book";

  constructor(private http: HttpClient) { }

  getBooks(): Observable<Book[]> {
    const url = `${this.booksUrl}/get`;
    return this.http.get<Book[]>(url);
  }

  getBook(id: number): Observable<Book> {
    const url = `${this.booksUrl}/getbyid/${id}`;
    return this.http.get<Book>(url);
  }

  addBook(book: Book): Observable<Book> {
    const url = `${this.booksUrl}/add`;
    return this.http.post<Book>(url, book, this.httpOptions);
  }

  searchByName(name: string): Observable<Book[]> {
    const url = `${this.booksUrl}/searchbyname/${name}`;
    return this.http.get<Book[]>(url);
  }

}
