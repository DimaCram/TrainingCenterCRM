import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { throwError } from "rxjs";
import { catchError } from 'rxjs/operators';
import { ToastService } from "../components/toast/toast.service";

@Injectable({
    providedIn: 'root'
})
export class HttpErrorInterceptorService implements HttpInterceptor {

    constructor(private toastService: ToastService) {}
    intercept(request: HttpRequest<any>, next: HttpHandler) {
        return next.handle(request)
            .pipe(
                catchError((error: HttpErrorResponse) => {
                    const errorMessage = this.setError(error);
                    console.log(JSON.stringify(error));
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
        } else {
          // server side error
            if (error.status!==0) {

                if(error.error.errors)
                    errorMessage = this.transformError(error.error.errors)
                else
                    errorMessage = error.error.message || error.error;
            }
        }
        return errorMessage;
    }
    transformError(err: any) {
        let messages = "";
        Object.entries(err).forEach(([key, value]) =>{
            let ar = value as string[];
            messages += `${key}: ${ar.join(',')} `;
        });
        return messages;
    }
}
