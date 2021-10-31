import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { throwError } from "rxjs";
import { catchError } from 'rxjs/operators';
import { ToastService } from "../components/toast/toast.service";

@Injectable({
    providedIn: 'root'
})
export class HttpErrorInterceptorService implements HttpInterceptor {

    constructor(private toastService: ToastService,
                private router: Router) {}

    intercept(request: HttpRequest<any>, next: HttpHandler) {
        return next.handle(request)
            .pipe(
                catchError((error: HttpErrorResponse) => {
                    this.setStatusError(error);

                    const errorMessage = this.setError(error);
                    console.log(JSON.stringify(error));
                    if(errorMessage)
                        this.toastService.showError(JSON.stringify(errorMessage));

                    return throwError(errorMessage);
                })
            );
    }

    setError(error: HttpErrorResponse): string {
        let errorMessage = 'Unknown error occured';
        if(error.error instanceof ErrorEvent) {
            // Client side error
            errorMessage = error.error.error;
        }
        else {
            errorMessage = error.error
        }
        return errorMessage;
    }
    setStatusError(error: HttpErrorResponse) {
        if (error.status === 401 || error.status === 403 || error.status === 0 || error.status === 500) {
            this.router.navigate(['/error', error.status]);
        }
    }
}
