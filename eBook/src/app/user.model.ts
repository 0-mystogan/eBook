import { Book } from './book.model';
import { Order } from './order.model';

export interface User {
   id : number,
   picture: string,
   firstname : string,
   lastname: string,
   email: string,
   password : string,
   books: Book[],
   orders: Order[]
}