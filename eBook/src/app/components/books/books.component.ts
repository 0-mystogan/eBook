import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
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
  timeout: any = null;
  searchName: string;

  isAdmin: boolean = true;

  constructor(private booksService: BooksService) {
  }

  ngOnInit(): void {
    this.getBooks();
  }

  getBooks() {
    this.booksService.getBooks().subscribe(data =>
      this.books = data.collection);
  }

  searchByName(name: string) {
    if (name === "") {
      this.getBooks();
    }
    else {
      this.booksService.searchByName(name).subscribe(data => {
        this.books = data.collection;
      });
    }
  }

  onSearchByName(event: any) {

    clearTimeout(this.timeout);
    var $this = this;

    this.timeout = setTimeout(function () {
      if (event.keyCode != 13) {
        $this.searchByName($this.searchName);
      }
    }, 1000);
  }

  deleteBook(id: number) {
    let r = confirm("Do you want to delete book?");
    if (r) {
      this.booksService.deleteBook(id).subscribe();
      this.getBooks();
      location.reload();
    }
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
