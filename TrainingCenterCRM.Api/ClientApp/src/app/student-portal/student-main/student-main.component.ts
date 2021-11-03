import { Component } from "@angular/core";

@Component({
    selector: 'app-student-main',
    templateUrl: './student-main.component.html',
 })
export class StudentMainComponent {
    isActive = false;

    toggle() {
        this.isActive = !this.isActive;
    }
}