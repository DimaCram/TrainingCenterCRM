import { Component } from "@angular/core";
import { Location } from '@angular/common';
import { ActivatedRoute, Router } from "@angular/router";
import { AccountService } from "src/app/services/account.service";

@Component({
    selector: 'app-status-error',
    templateUrl: './status-error.component.html'
})

export class StatusErrorComponent{
    code: number;
    errorMessage: string;
    constructor(private route: ActivatedRoute,
                private router: Router,
                private accountService: AccountService){}

    ngOnInit(): void {
        this.code = +this.route.snapshot.params['code'];
        console.log(this.code)

        switch(this.code){
            case 401:
            case 403:
                this.errorMessage = "Access to this resource is denied.";
                break;
            case 404:
                this.errorMessage = "Sorry, that page doesn't exist.";
                break;
            case 500:
                this.errorMessage = "Internal Server Error.";
                break;
            default:
                this.errorMessage = "Sorry, something went wrong.";
                break;
        }
    }
    goHomePage() {
        const role = this.accountService.getRole();

        switch(role){
            case "manager":
                this.router.navigate(['manager'])
                break;
            case "teacher":
                this.router.navigate(['teacher'])
                break;
            default:
                this.router.navigate(['login'])
                break;
        }
    }
}
