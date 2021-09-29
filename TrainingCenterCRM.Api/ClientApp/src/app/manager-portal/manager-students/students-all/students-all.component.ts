import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ToastService } from 'src/app/components/toast/toast.service';
import { Student } from 'src/app/models/student.model';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-manager-main',
  templateUrl: './students-all.component.html',
})
export class StudentsAllComponent {
    public students: Student[] = [];
    public studentInfo: Student;
    public page = 1;
    public pageSize = 5;

    constructor(private studentService : StudentService,
                private titleService: Title,
                private modalService: NgbModal,
                private toastService: ToastService){}

    ngOnInit(): void {
      this.titleService.setTitle("Students - Training Center")

      this.studentService.getStudents().subscribe(result => {
        this.students = result;
      },
      error => {
        this.toastService.showError((<any>error).message);
        console.error(error);
      });
    }

    deleteStudent(id): void{
      this.studentService.deleteStudent(id).subscribe(result => {
        const removeIndex = this.students.findIndex( item => item.id === id );
        this.students.splice( removeIndex, 1 );
      },
      error => {console.error(error);});
    }

    open(content, studentId) {
      this.studentService.getStudent(studentId).subscribe(result => {
        this.studentInfo = result;
        this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'});
      },
      error => {
        this.toastService.showError((<any>error).message);
        console.error(error);
      });
    }
}
