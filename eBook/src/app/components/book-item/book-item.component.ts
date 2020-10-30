import { Component, OnInit, Input } from '@angular/core';
import { Book } from 'src/app/book.model';
import {BOOKS} from '../../books';

@Component({
  selector: 'book-item',
  templateUrl: './book-item.component.html',
  styleUrls: ['./book-item.component.scss']
})
export class BookItemComponent implements OnInit {
   @Input() book : Book;

  books : Book[] =  BOOKS;

   constructor() { 
   }

  ngOnInit(): void {
    
  }

  addCart(book : Book){
    console.log(book);
  }
    
}
