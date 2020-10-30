import { Component, Input, OnInit } from '@angular/core';
import { BooksService } from 'src/app/services/books.service';
import { Book } from '../../book.model';
import { BOOKS } from  '../../books';

@Component({
  selector: 'app-book',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.scss']
})
export class BooksComponent implements OnInit {
  @Input() book : Book;
   books : Book[];
   isShow : boolean = false;
   showBook : Book;


  constructor(private booksService : BooksService) { }

  ngOnInit(): void {
    this.books = this.booksService.getBooks();
  }

  showItem(book){
    if(!this.isShow)
      this.isShow = true;
      else if(this.isShow)
      this.isShow = false;
      console.log(book);
      this.showBook = book;
  }

}
