import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BooksComponent } from './components/books/books.component';
import { BookItemComponent } from './components/book-item/book-item.component';
import { HomeComponent } from './components/layout/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { ProfileComponent } from './components/profile/profile.component';
import { AddBookComponent } from './components/add-book/add-book.component';


const routes: Routes = [
   {
      path: '', component: /*HomeComponent*/ BooksComponent
   },
   {
      path: 'books', component: BooksComponent
   },
   {
      path: 'register', component: RegisterComponent
   },
   {
      path: 'profile', component: ProfileComponent
   },
   {
      path: 'book/:id', component: BookItemComponent
   },
   {
      path: 'add', component: AddBookComponent
   },
];

@NgModule({
   imports: [RouterModule.forRoot(routes)],
   exports: [RouterModule]
})

export class AppRoutingModule { }
