import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";

@Component({
    selector: 'app-student',
    templateUrl: './student.component.html'
  })
  export class StudentComponent {
    public students: Student[];
    studentName = '';

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      http.get<Student[]>(baseUrl + 'students').subscribe(result => {
        this.students = result;
        console.log(result);
      }, error => console.error(error));
    }
  }

  export interface Student {
    id: number;
    name: string;
    surname: string;
    age: number;
  }
