import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Book } from 'src/app/book.model';
import { BooksService } from 'src/app/services/books.service';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpEventType } from '@angular/common/http';



@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.scss']
})
export class AddBookComponent implements OnInit {

  @Output() public onUploadFinished = new EventEmitter();
  public progress: number;
  public message: string;
  checkoutForm;

  constructor(private booksService: BooksService, private formBuilder: FormBuilder, private router: Router) {
    this.checkoutForm = formBuilder.group({
      name: '',
      author: '',
      description: '',
      price: null,
      currrency: '',
      quantity: null
    });
  }

  ngOnInit(): void {
  }

  onSubmit(book, file) {
    book.image = `https://localhost:44375/Resources/Images/${file[0].name}`
    this.checkoutForm.reset();
    this.booksService.addBook(book).subscribe();
    this.router.navigate(['/books']);
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
}
