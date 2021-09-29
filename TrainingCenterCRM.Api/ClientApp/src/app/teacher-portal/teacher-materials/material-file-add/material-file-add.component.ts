import { Component, ElementRef, ViewChild } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { Course } from "src/app/models/course.model";
import { CourseService } from "src/app/services/courses.service";
import { MaterialService } from "src/app/services/material.service";

@Component({
    selector: 'material-add-file',
    templateUrl: './material-file-add.component.html',
})
export class MaterialFileAddComponent {
    id: number;
    form: FormGroup;
    courses: Course[] = [];
    selectedFiles: File[] = [];

    @ViewChild("fileDropRef") fileDropEl: ElementRef;
    files: any[] = [];

    constructor(private fb: FormBuilder,
                private materialService: MaterialService,
                private courseService: CourseService,
                private route: ActivatedRoute,
                private router: Router,
                private titleService: Title){}


    ngOnInit(): void {
        this.titleService.setTitle("Edit material - Training Center")

        this.id = this.route.snapshot.params['id'];

        this.courseService.getCourses().subscribe(res => {
            this.courses = res;
        })
    }

    onSubmit(){
    }


   /**
   * on file drop handler
   */
    onFileDropped($event) {
        this.prepareFilesList($event);
    }

    /**
     * handle file from browsing
     */
    fileBrowseHandler(files) {
        this.prepareFilesList(files);
    }

    prepareFilesList(files: Array<any>) {
        for (const item of files) {
            this.files.push(item);
        }
        console.log(files);
        this.fileDropEl.nativeElement.value = "";
    }

  }