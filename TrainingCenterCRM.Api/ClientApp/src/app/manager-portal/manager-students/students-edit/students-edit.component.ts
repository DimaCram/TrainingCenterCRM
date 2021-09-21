import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Student } from 'src/app/models/student.model';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-manager-main',
  templateUrl: './students-edit.component.html',
})
export class StudentsEditComponent {

  constructor(private fb: FormBuilder,
              private studentSevice: StudentService,
              private route: ActivatedRoute){}

  formModel = this.fb.group({
    Name: ['', Validators.required],
    Surname: ['', Validators.required],
    Age: ['', [Validators.required]],
    Email: ['', Validators.compose([
                  Validators.email,
                  Validators.required])
    ],
    Password: ['', Validators.compose([
      Validators.required,
      Validators.pattern('(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&.])[A-Za-z\d$@$!%*?&].{8,}')])
   ]
  })


  onSubmit(){
    this.editStudent();
  }


  editStudent(): void{
    let id = this.route.snapshot.params['id'];
    let student : Student = new Student(id, this.formModel.value.Name, this.formModel.value.Surname, this.formModel.value.Age);
    student.email = this.formModel.value.Email;
    student.password = this.formModel.value.Password;

    console.log(student);

    this.studentSevice.egitStudent(student).subscribe(result => {
      console.log(result);
    },
    error => {console.error(error);});
  }
}
