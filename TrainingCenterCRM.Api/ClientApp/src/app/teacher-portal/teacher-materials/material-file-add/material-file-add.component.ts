import { Component, ElementRef, ViewChild } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { ToastService } from "src/app/components/toast/toast.service";
import { Course } from "src/app/models/course.model";
import { File } from "src/app/models/file.model";
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
    selectedFiles: string[] = [];
    fileLengthError: string = "";

    @ViewChild("fileDropRef") fileDropEl: ElementRef;
    files: any[] = [];

    constructor(private fb: FormBuilder,
                private materialService: MaterialService,
                private courseService: CourseService,
                private toastService: ToastService,
                private route: ActivatedRoute,
                private router: Router,
                private titleService: Title){}


    ngOnInit(): void {
        this.titleService.setTitle("Edit material - Training Center")

        this.id = this.route.snapshot.params['id'];

        this.courseService.getCourses().subscribe(res => {
            this.courses = res;
        })

        this.form = this.fb.group({
            courseId: ['', Validators.required]
        });
    }

    deleteFile(index: number){
        this.files.splice(index, 1);
    }

    onSubmit(){
        if(this.files.length === 0)
        {
            this.fileLengthError = "Select minimum one file";
            return;
        }

        let file : File = new File();

        file.courseId = this.form.value.courseId;
        file.files = this.files;

        this.materialService.addFile(file).subscribe(res => {
            this.router.navigate(['../'], { relativeTo: this.route });
        })
    }

    onFileDropped($event) {
        this.prepareFilesList($event);
    }

    fileBrowseHandler(files) {
        this.prepareFilesList(files);
    }

    prepareFilesList(files: Array<any>) {
        for (const item of files) {
            if(this.validateFile(item))
                this.files.push(item);
        }
        this.fileDropEl.nativeElement.value = "";
        console.log(this.files)
    }

    validateFile(file): boolean {
        const allowedExtensions = ['doc', 'docx', 'ppt', 'pptx', 'pdf'],
              sizeLimit = 5_000_000,
              bytesInMb = 1000000;

        const fileExtension = file.name.split(".").pop();

        if (!allowedExtensions.includes(fileExtension)) {
            this.toastService.showError(`"${file.name}" type not allowed. Allowed types ${allowedExtensions.join(", ")}.`);
            return false;
        } else if (file.size > sizeLimit) {
            this.toastService.showError(`"${file.name}" size too large. Max size ${Math.trunc(sizeLimit / bytesInMb)} MB`);
            return false;
        }
        return true;
    }
}