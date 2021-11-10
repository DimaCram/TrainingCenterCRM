import { Injectable, TemplateRef } from "@angular/core";

@Injectable({
    providedIn: 'root'
  })
  export class ToastService {
    toasts: any[] = [];

    show(textOrTpl: string | TemplateRef<any>, options: any = {}) {
      this.toasts.push({ textOrTpl, ...options });
    }

    showError(message: string | TemplateRef<any>){
      const options = {
        classname: 'bg-danger text-light',
        delay: 5000 ,
        autohide: true,
        headertext: 'Error!'
      };
      this.toasts.push({message, ...options});
    }

    showSuccess(message: string | TemplateRef<any>){
      const options = {
        classname: 'bg-success text-light',
        delay: 5000 ,
        autohide: true,
        headertext: 'Success!'
      };
      this.toasts.push({message, ...options});
    }

    remove(toast) {
      this.toasts = this.toasts.filter(t => t !== toast);
    }
  }