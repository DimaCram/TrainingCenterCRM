import { HttpClient } from "@angular/common/http";
import { Component, ElementRef, ViewChild } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { Course } from "src/app/models/course.model";
import { Topic } from "src/app/models/topic.model";
import { CourseService } from "src/app/services/courses.service";
import { TopicService } from "src/app/services/topic.service";

@Component({
    selector: 'manager-course-edit',
    templateUrl: './course-edit.component.html'
})

export class CourseEditComponent{
    topics : Topic[];
    form: FormGroup;
    id: number;
    filePath : string = "";

    @ViewChild("fileDropRef") fileDropEl: ElementRef;
    files: any[] = [];

    constructor(private fb: FormBuilder,
                private courseSevice: CourseService,
                private topicService: TopicService,
                private route: ActivatedRoute,
                private router: Router,
                private titleService: Title
                ){}


    ngOnInit(): void {
        this.titleService.setTitle("Edit course - Training Center")

        this.id = this.route.snapshot.params['id'];

        if (this.id) {
            this.courseSevice.getCourse(this.id)
                             .subscribe(res => {
                               this.form.patchValue(res);
                               if(res.pathToIcon)
                                this.filePath = res.pathToIcon;
                              });
        }

        this.topicService.getTopics().subscribe(res => this.topics = res);


        this.form = this.fb.group({
            title: ['', Validators.required],
            description: [''],
            topicId: ['', Validators.required]
        });
    }

    onSubmit(){
        this.editCourse();
    }

    editCourse(): void{
        let course : Course = new Course();

        if(this.id){
            course.id = +this.id;
        }

        course.title = this.form.value.title;
        course.description = this.form.value.description;
        course.topicId = +this.form.value.topicId
        course.file = this.files[0];

        this.courseSevice.egitCourse(course).subscribe(result => {
            if(this.id)
                this.router.navigate(['../../'], { relativeTo: this.route });
            else
                this.router.navigate(['../'], { relativeTo: this.route });
        });
    }

  /**
   * on file drop handler
   */
  onFileDropped($event) {
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
      this.filePath = reader.result as string;
    }
    reader.readAsDataURL(file)
  }

}