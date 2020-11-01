import { User } from './user.model';

export const USERS: User[] = [
   {
      id: 1,
      firstname: "Jasir",
      lastname: "Burić",
      email: "jasir.buric@edu.fit.ba",
      password: "password123",
      address: "Gorazdanska 96",
      isAdmin: true
   },
   {
      id: 2,
      firstname: "Muhamed",
      lastname: "Halkić",
      email: "muhamed.halkic@edu.fit.ba",
      password: "password321",
      address: "Halkici23",
      isAdmin: false
   }
]