import { Book } from './book.model';
import { Order } from './order.model';

export interface User {
   id : number,
   firstname : string,
   lastname: string,
   email: string,
   password : string,
   address: string,
   isAdmin: boolean,
}