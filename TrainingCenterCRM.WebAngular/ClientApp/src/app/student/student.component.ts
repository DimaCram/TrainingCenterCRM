import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";

@Component({
    selector: 'app-student',
    templateUrl: './student.component.html',
    styleUrls: ['./student.compomemt.css']
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

    sort(prop: string, isUp : boolean){
      this.students = this.students.sort(function (a, b) {
        if(isUp){
          return (a[prop] > b[prop]) ? 1 : ((a[prop] < b[prop]) ? -1 : 0);
        }
        else{
          return (b[prop] > a[prop]) ? 1 : ((b[prop] < a[prop]) ? -1 : 0);
        }
      });
    }
  }

  export interface Student {
    id: number;
    name: string;
    surname: string;
    age: number;
  }
