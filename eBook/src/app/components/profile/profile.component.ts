import { HttpEventType } from '@angular/common/http';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  @Output() public onUploadFinished = new EventEmitter();
  click : boolean;
  public progress: number;
  public message: string;
  public img : string;

  constructor(public userService : UserService) { }

  ngOnInit(): void {
  }
  openForm(value : boolean){
    this.click = value;
  }
  logOut(){
    this.userService.user = null;
  }

  uploadFile(files){
    if(files.length === 0){
      return;
    }else {
      console.log(files);
      this.userService.uploadProfileImage(files).subscribe(event => {
        if(event.type === HttpEventType.UploadProgress)
          this.progress = Math.round(100 * event.loaded / event.total);
        else if (event.type === HttpEventType.Response){
          this.message = 'Upload success';
          this.onUploadFinished.emit(event.body);
        }
      });
    }

    setTimeout(()=>{
      this.userService.user.image = `https://localhost:44375/Resources/Images/${files[0].name}`
      this.userService.upadageImg(this.userService.user).subscribe(user => this.userService.user = user, error => console.log(error))
    }, 3000);
    
  }
}
