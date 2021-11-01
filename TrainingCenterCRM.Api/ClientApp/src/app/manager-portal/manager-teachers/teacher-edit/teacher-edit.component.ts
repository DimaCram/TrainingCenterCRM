import { Component, ElementRef, Inject, ViewChild } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { ToastService } from "src/app/components/toast/toast.service";
import { Teacher } from "src/app/models/teacher.model";
import { TeacherService } from "src/app/services/teacher.service";

@Component({
    selector: 'manager-teacher-edit',
    templateUrl: './teacher-edit.component.html',
  })
  export class TeacherEditComponent {

    icon: string;
    baseUrl: string;
    filePath : string = "";
    form: FormGroup;
    id: number;


    @ViewChild("fileDropRef") fileDropEl: ElementRef;
    files: any[] = [];


    constructor(private fb: FormBuilder,
        private teacherService: TeacherService,
        private route: ActivatedRoute,
        private router: Router,
        private titleService: Title,
        @Inject('BASE_URL') baseUrl: string,
        private toastService: ToastService)
        {
          this.baseUrl = baseUrl;
        }

    ngOnInit(): void {
      this.titleService.setTitle("Edit teacher - Training Center")

      this.id = this.route.snapshot.params['id'];

      if (this.id) {
        this.teacherService.getTeacher(this.id)
                           .subscribe(res => {
                              this.form.patchValue(res);
                              if(res.pathToIcon){
                                this.filePath = res.pathToIcon;
                                this.icon = `${this.baseUrl}/${res.pathToIcon}`;
                              }
                            });

        this.form = this.fb.group({
          name: ['', Validators.required],
          surname: ['', Validators.required],
          age: ['', [Validators.required]],
          bio: ['', [Validators.required]],
          userId: ['']
          })

      }else{
        this.form = this.fb.group({
          name: ['', Validators.required],
          surname: ['', Validators.required],
          age: ['', [Validators.required]],
          bio: ['', [Validators.required]],
          email: ['', Validators.compose([
                        Validators.email,
                        Validators.required])
          ],
          password: ['', Validators.compose([
            Validators.required,
            Validators.pattern('(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&.])[A-Za-z\d$@$!%*?&].{8,}')])
          ],
          userId: ['']
          })
      }
    }

    onSubmit(){
        this.editTeacher();
    }

    editTeacher(): void{
        let teacher : Teacher = new Teacher();
        if(!this.id){
            teacher.email = this.form.value.email;
            teacher.password = this.form.value.password;
        }
        else{
            teacher.id = +this.id;
            teacher.userId = this.form.value.userId;
        }
        teacher.name = this.form.value.name
        teacher.surname = this.form.value.surname
        teacher.age = this.form.value.age
        teacher.file = this.files[0];
        teacher.bio = this.form.value.bio;

        if(!teacher.file)
          teacher.pathToIcon = this.filePath;

        this.teacherService.egitTeacher(teacher).subscribe(result => {

          if(this.id){
            this.router.navigate(['../../'], { relativeTo: this.route });
            this.toastService.showSuccess("Teacher edited");
          }
           else{
            this.router.navigate(['../'], { relativeTo: this.route });
            this.toastService.showSuccess("Teacher added");
           }
        });
      }

  /**
   * on file drop handler
   */
  onFileDropped($event) {
      console.log($event);
    this.prepareFilesList($event);
    this.imagePreview($event);
  }

  /**
   * handle file from browsing
   */
  fileBrowseHandler(files) {
    this.prepareFilesList(files);
    this.imagePreview(this.files);
  }

  prepareFilesList(files: Array<any>) {
    for (const item of files) {
      this.files.push(item);
    }
    this.fileDropEl.nativeElement.value = "";
  }

  imagePreview(files) {
    const file = files[0];

    const reader = new FileReader();
    reader.onload = () => {
      this.icon = reader.result as string;
    }
    reader.readAsDataURL(file)
  }
}