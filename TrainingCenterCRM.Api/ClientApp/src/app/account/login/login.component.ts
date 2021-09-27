import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { NgForm } from "@angular/forms";
import { Router } from "@angular/router";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html'
})

export class LoginComponent{
    baseUrl: string;
    invalidLogin: boolean;

    constructor(private http: HttpClient,
                @Inject('BASE_URL') baseUrl: string,
                private router: Router)
    {
        this.baseUrl = baseUrl;
    }

    login(form: NgForm){
        const credentias = {
            'username': form.value.username,
            'password': form.value.password
        }

        this.http.post(this.baseUrl + 'api/accounts/login', credentias).subscribe(res => {
            const token = (<any>res).token;
            localStorage.setItem("jwt", token);
            this.invalidLogin = false;
            this.router.navigate(['manager'])
        },
        err => {console.log(err); this.invalidLogin = true;})
    }
}