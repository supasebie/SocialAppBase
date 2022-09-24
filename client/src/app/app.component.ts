import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'InPrompts';
  users: any;

  constructor(private accountService: AccountService) {
  }

  ngOnInit(): any {
    this.setCurrentUser();
  }

  setCurrentUser(): any{
    const storageItem = localStorage.getItem('user')
    let user: User | null = null;
    if (storageItem)
    {
      user = JSON.parse(storageItem);
    }
    this.accountService.setCurrentUser(user);
  }


}
