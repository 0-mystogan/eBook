import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { AddBook } from 'src/app/add-book.model';
import { Book } from 'src/app/book.model';
import { BooksService } from 'src/app/services/books.service';


@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.scss']
})
export class AddBookComponent implements OnInit {

  book: AddBook;
  
  name: string;
  author: string;
  description: string;
  price: number;
  currrency: string;
  image: string;
  quantity: number;

  
  constructor(private booksService: BooksService) { }

  ngOnInit(): void {
  }


  // formBooks = new FormGroup({
  //   name : new FormControl(''),
  //   image: new FormControl(''),
  //   description:  new FormControl(''),
  //   price: new FormControl(''),
  //   author: new FormControl(''),
  //   currrency: new FormControl(''),
  //   quantity: new FormControl('')
  // })

  
  
  onSubmit(){

    // this.book.name = this.name;
   this.book = {
    name: this.name,
    author : this.author,
    description: this.description,
    price : this.price,
    currrency : this.currrency,
    image : this.image,
    quantity : this.quantity
   }
    // this.book.author = this.author;
    // this.book.description = this.description;
    // this.book.price = this.price;
    // this.book.qurrrency = this.currrency;
    // this.book.image = this.image;
    // this.book.quantity = this.quantity;
      
    this.booksService.addBook(this.book)
    

    

  }
  
}
