import { Injectable } from '@angular/core';
import { Book } from '../book.model';
import { BOOKS } from '../books';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor() { }

  getBooks() : Book[]{
    return BOOKS;
  }
}
