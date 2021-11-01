import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { ToastService } from 'src/app/components/toast/toast.service';
import { Teacher } from 'src/app/models/teacher.model';
import { TeacherService } from 'src/app/services/teacher.service';

@Component({
  selector: 'manager-teacher-all',
  templateUrl: './teacher-all.component.html',
})
export class TeacherAllComponent {
    public teachers: Teacher[] = [];
    public page = 1;
    public pageSize = 5;

    constructor(private teacherService : TeacherService,
                private titleService: Title,
                private ngxService: NgxUiLoaderService,
                private toastService: ToastService){}

    ngOnInit(): void {
      this.titleService.setTitle("Teachers - Training Center")

      this.ngxService.startLoader("teachersLoader");
      this.teacherService.getTeachers().subscribe(result => {
        this.ngxService.stopLoader("teachersLoader");
        this.teachers = result;
      });
    }

    deleteTeacher(id): void{
      this.teacherService.deleteTeacher(id).subscribe(result => {
        const removeIndex = this.teachers.findIndex( item => item.id === id );
        this.teachers.splice( removeIndex, 1 );

        this.toastService.showSuccess("Teacher deleted");
      });
    }
}