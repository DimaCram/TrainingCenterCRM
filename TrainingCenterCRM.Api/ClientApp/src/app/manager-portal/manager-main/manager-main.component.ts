import { Component } from '@angular/core';

@Component({
  selector: 'app-manager-main',
  templateUrl: './manager-main.component.html',
})
export class ManagerMainComponent {
    isActive = false;

    toggle() {
        this.isActive = !this.isActive;
    }
}