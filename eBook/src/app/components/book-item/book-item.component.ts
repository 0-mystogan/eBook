import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Book } from 'src/app/book.model';
import { BooksService } from 'src/app/services/books.service';
import { BOOKS } from '../../books';

@Component({
  selector: 'book-item',
  templateUrl: './book-item.component.html',
  styleUrls: ['./book-item.component.scss']
})
export class BookItemComponent implements OnInit {
  book: Book;
  id: number;

  constructor(private booksService: BooksService, private route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.getBook();
    console.log(this.book);
  }

  getBook() {
    this.booksService.getBook(+this.route.snapshot.params['id']).subscribe(data => this.book = data.book);
  }

  addCart(book: Book) {
    console.log(book);
  }

}
