import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { User } from "../models/user.model";

Injectable()
@Injectable()
export class AccountService{
    baseUrl: string;

    constructor(private http : HttpClient, @Inject('BASE_URL') baseUrl: string){
        this.baseUrl = baseUrl;
    }

    login(user : User){
        user.email = ""
        user.password = ""
        return this.http.post(this.baseUrl + 'api/accounts/login', user)
    }
}