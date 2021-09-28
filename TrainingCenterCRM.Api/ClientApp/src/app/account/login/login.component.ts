import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { FormBuilder, FormGroup, NgForm, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { Router } from "@angular/router";
import { User } from "src/app/models/user.model";
import { AccountService } from "src/app/services/account.service";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html'
})

export class LoginComponent{
    baseUrl: string;
    invalidLogin: boolean;
    form: FormGroup;

    constructor(private http: HttpClient,
                @Inject('BASE_URL') baseUrl: string,
                private router: Router,
                private accountService: AccountService,
                private fb: FormBuilder,
                private titleService: Title)
    {
        this.baseUrl = baseUrl;
    }

    ngOnInit(): void {
        this.titleService.setTitle("Login - Training Center")

        this.form = this.fb.group({
            email: ['', Validators.compose([
                            Validators.email,
                            Validators.required
                        ])],
            password: ['', Validators.required],
        });
    }

    login(){
        let user = new User();
        user.email = this.form.value.email;
        user.password = this.form.value.password;

        this.accountService.login(user).subscribe(res => {
            const token = (<any>res).token;
            localStorage.setItem("jwt", token);
            this.invalidLogin = false;
            this.router.navigate(['manager'])
        },
        err => {console.log(err); this.invalidLogin = true;})
    }
}