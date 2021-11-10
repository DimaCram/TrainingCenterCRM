import { Component } from "@angular/core";

@Component({
    selector: 'app-teacher-main',
    templateUrl: './teacher-main.component.html',
  })
  export class TeacherMainComponent {
      isActive = false;

      toggle() {
          this.isActive = !this.isActive;
      }
  }