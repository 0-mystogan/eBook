import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BooksService } from 'src/app/services/books.service';
import { Book } from '../../book.model';


@Component({
  selector: 'app-book',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.scss']
})
export class BooksComponent implements OnInit {
  books: Book[];
  isShow: boolean = false;
  showBook: Book;


  constructor(private booksService: BooksService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.getBooks();
  }

  getBooks() {
    this.booksService.getBooks().subscribe(data =>
      this.books = data.collection);
  }

  showItem(book) {
    if (!this.isShow)
      this.isShow = true;
    else if (this.isShow)
      this.isShow = false;
    console.log(book);
    this.showBook = book;
  }

}
