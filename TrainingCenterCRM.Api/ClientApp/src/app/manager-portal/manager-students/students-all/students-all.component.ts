import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Student } from 'src/app/models/student.model';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-manager-main',
  templateUrl: './students-all.component.html',
})
export class StudentsAllComponent {
    public students: Student[];

    constructor(private studentService : StudentService,
                private titleService: Title){}

    ngOnInit(): void {
      this.titleService.setTitle("Students - Training Center")

      this.studentService.getStudents().subscribe(result => {
        this.students = result;
      },
      error => {console.error(error);});
    }

    deleteStudent(id): void{
      this.studentService.deleteStudent(id).subscribe(result => {
        const removeIndex = this.students.findIndex( item => item.id === id );
        this.students.splice( removeIndex, 1 );
      },
      error => {console.error(error);});
    }
}
