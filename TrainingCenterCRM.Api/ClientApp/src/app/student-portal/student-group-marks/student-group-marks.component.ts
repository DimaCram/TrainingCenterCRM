import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { ActivatedRoute, Router } from "@angular/router";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { ToastService } from "src/app/components/toast/toast.service";
import { StudentMark } from "src/app/models/student-mark.model";
import { Topic } from "src/app/models/topic.model";
import { StudentMarkService } from "src/app/services/student-mark.service";
import { TopicService } from "src/app/services/topic.service";

@Component({
    selector: 'student-group-marks',
    templateUrl: './student-group-marks.component.html',
  })
  export class StudentGroupMarksComponent {

    public filteredGroupMarks: StudentMark[] = [];
    private groupMarks: StudentMark[] = [];

    private groupId: number;

    public page = 1;
    public pageSize = 5;


    constructor(private studentMarkService : StudentMarkService,
                private titleService: Title,
                private ngxService: NgxUiLoaderService,
                private router: Router)
                {
                  this.groupId = +localStorage.getItem('groupId');
                  if(!this.groupId)
                    this.router.navigate(["student"]);
                }

    ngOnInit(): void {
      this.titleService.setTitle("Student marks - Training Center")

      this.ngxService.startLoader("studentGroupMarksLoader");
      this.studentMarkService.getStudentGroupMarks(this.groupId).subscribe(result => {
        this.ngxService.stopLoader("studentGroupMarksLoader");
        this.groupMarks = result;
        this.filteredGroupMarks = result;
      });
    }

    search(searchText: string){
      this.filteredGroupMarks = this.groupMarks.filter(mark => {
        const term = searchText.toLowerCase();
        return mark.mark.toString().includes(term)
            || mark.comment.toLowerCase().includes(term)
            || mark.material.name.toLowerCase().includes(term)
            || mark.material.materialType.toLowerCase().includes(term);
      });
    }
}