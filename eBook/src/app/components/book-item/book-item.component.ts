import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Book } from 'src/app/book.model';
import { BooksService } from 'src/app/services/books.service';
import { BooksComponent } from '../books/books.component';


@Component({
  selector: 'book-item',
  templateUrl: './book-item.component.html',
  styleUrls: ['./book-item.component.scss']
})
export class BookItemComponent implements OnInit {
  book: Book;
  id: number;
  checkoutForm;

  constructor(private booksService: BooksService, private route: ActivatedRoute, private formBuilder: FormBuilder) {
    this.checkoutForm = formBuilder.group({
      id: +this.route.snapshot.params['id'],
      name: '',
      author: '',
      description: '',
      price: null,
      currrency: '',
      image: '',
      quantity: null
    });
  }

  ngOnInit(): void {
    this.getBook();
  }

  getBook() {
    this.booksService.getBook(+this.route.snapshot.params['id']).subscribe(data => this.book = data.book);
  }

  onSubmit(book) {
    this.checkoutForm.reset();
    this.booksService.updateBook(book).subscribe();
    location.reload();
  }

  addCart(book: Book) {
    console.log(book);
  }

}
