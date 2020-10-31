import { User } from './user.model';

export const USERS : User[] = [
   {
      id : 1,
      picture: "../assets/jasir.jpg",
      firstname : "Jasir",
      lastname : "Burić",
      email : "jasir.buric@edu.fit.ba",
      password : "password123",
      books: [
         {
            id : 6,
            picture :"../assets/BatmanBlackMirror.jpg",
            relacedate: new Date().toLocaleDateString(),
            name : "Batman : The Black Mirrort",
            description: `A New York Times #1 Bestseller and Amazon Best Book of 2011! In "The
            Black Mirror," a series of brutal murders pushes Batman's detective skills to
            the limit and forces him to confront one of Gotham City's oldest evils..`,
            price : 40,
            author : "Scott Snyder"

         },
         {
            id : 7,
            picture: "../assets/TheEndOfTheDay.jpg",
            relacedate: new Date().toLocaleDateString(),
            name : "The End of the Day",
            description: `From the New York Times bestselling, Booker-longlisted author of Did You Ever Have a Family 'Fabulously rich and compelling' Daily Mail Following his acclaimed New York Times bestseller, Did You Ever Have a Family, Bill Clegg returns with a profoundly moving, emotionally resonant second novel about the complicated bonds and breaking points of family and friendship.`,
            price : 40,
            author : "Bill Clegg",

         },
      ],
      orders:[],
   },
   {
      id : 2,
      picture: "",
      firstname : "Muhamed",
      lastname : "Halkić",
      email : "muhamed.halkic@edu.fit.ba",
      password : "password321",
      books: [],
      orders:[]
   }
]