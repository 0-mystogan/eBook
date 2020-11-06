import { Component, OnInit } from '@angular/core';
import { Page } from 'src/app/page.model';
import { PageService } from 'src/app/services/page.service';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/app/user.model';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit {
  page : Page;
  
  number : number = 0;

  constructor(public pageService : PageService, private userService : UserService) {
    
   }

  ngOnInit(): void {
    this.WaitUsers();
  }

  private WaitUsers = async ()  => {
    await this.pageService.getPageUsers().subscribe(page => this.page = page);
  }

  setUrl(url : string){
    if(url != null){
      this.pageService.pageUrl = url;
      this.WaitUsers();
    }
  }

  setPageNumber(num : number){
    this.pageService.pageUrl = `https://localhost:44375/api/user/getall?pageNumber=${num}&pageSize=10`;
    this.WaitUsers();
  }

  setAdmin(input : boolean, user : User){
    user.isAdmin = input;
    this.userService.updateUser(user).subscribe(user => console.log(user));
  }

  fakeArray(length: number): Array<any> {
    if (length >= 0) {
      return new Array(length);
    }
  }

}
