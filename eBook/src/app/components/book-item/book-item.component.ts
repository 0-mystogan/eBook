import { HttpEventType } from '@angular/common/http';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
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
  @Output() public onUploadFinished = new EventEmitter();
  public progress: number;
  public message: string;

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

  onSubmit(book, file) {
    book.image = `https://localhost:44375/Resources/Images/${file[0].name}`
    this.checkoutForm.reset();
    this.booksService.updateBook(book).subscribe();
    this.getBook();
    location.reload();
  }

  uploadFile(files) {
    if (files.length === 0) {
      return;
    } else {
      this.booksService.uploadBookImage(files)
        .subscribe(event => {
          if (event.type === HttpEventType.UploadProgress)
            this.progress = Math.round(100 * event.loaded / event.total);
          else if (event.type === HttpEventType.Response) {
            this.message = 'Upload success.';
            this.onUploadFinished.emit(event.body);
          }
        });
    }
  }

  addCart(book: Book) {
    console.log(book);
  }

}
