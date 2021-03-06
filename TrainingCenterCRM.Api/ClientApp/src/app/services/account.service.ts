import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { of } from "rxjs";
import { User } from "../models/user.model";

Injectable()
@Injectable()
export class AccountService{
    baseUrl: string;

    constructor(private http : HttpClient,
                @Inject('BASE_URL') baseUrl: string,
                private router: Router)
    {
        this.baseUrl = baseUrl;
    }

    login(user : User){
        return this.http.post(this.baseUrl + 'api/accounts/login', user)
    }

    logout() {
      localStorage.clear();
    }

    getRole() {
      return localStorage.getItem('role');
    }

    redirectToHomePage(){
      const role = this.getRole();

      switch(role){
          case "manager":
              this.router.navigate(['manager'])
              break;
          case "teacher":
              this.router.navigate(['teacher'])
              break;
          case "student":
              this.router.navigate(['student'])
              break;
          default:
              this.router.navigate(['login'])
              break;
      }
    }
}