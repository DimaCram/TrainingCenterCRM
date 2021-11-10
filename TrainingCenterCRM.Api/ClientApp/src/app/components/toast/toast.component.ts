import { Component, TemplateRef } from "@angular/core";
import { ModalDismissReasons, NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { ToastService } from "./toast.service";

@Component({
    selector: 'app-toasts',
    templateUrl: './toast.component.html'
})

export class ToastComponent{
    constructor(public toastService: ToastService) {}
    
    isTemplate(toast) { return toast.textOrTpl instanceof TemplateRef; }
}