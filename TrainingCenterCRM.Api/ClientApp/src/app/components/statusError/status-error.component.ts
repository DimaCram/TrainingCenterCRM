import { Component } from "@angular/core";
import { Location } from '@angular/common';
import { ActivatedRoute } from "@angular/router";

@Component({
    selector: 'app-status-error',
    templateUrl: './status-error.component.html'
})

export class StatusErrorComponent{
    code: number;
    errorMessage: string;
    constructor(private route: ActivatedRoute,
                private location: Location){}

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
    back() {
        this.location.back(); // <-- go back to previous location on cancel
    }
}
