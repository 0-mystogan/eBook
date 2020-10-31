import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { AddBook } from 'src/app/add-book.model';
import { Book } from 'src/app/book.model';
import { BooksService } from 'src/app/services/books.service';
import { FormBuilder } from '@angular/forms';


@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.scss']
})
export class AddBookComponent implements OnInit {

  checkoutForm;

  constructor(private booksService: BooksService, private formBuilder: FormBuilder) {
    this.checkoutForm = formBuilder.group({
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

  }

  onSubmit(book) {
    this.checkoutForm.reset();
    this.booksService.addBook(book).subscribe();
  }
}
