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
    selector: 'teacher-group-marks',
    templateUrl: './group-marks.component.html',
  })
  export class GroupMarksComponent {

    groupId: number;
    public groupMarks: StudentMark[] = [];

    public page = 1;
    public pageSize = 5;


    constructor(private studentMarkService : StudentMarkService,
                private titleService: Title,
                private ngxService: NgxUiLoaderService,
                private route: ActivatedRoute,
                private toastService: ToastService)
                {
                  this.groupId = +this.route.snapshot.queryParams['groupId']
                }

    ngOnInit(): void {
      this.titleService.setTitle("Group marks - Training Center")

      this.groupId = +this.route.snapshot.queryParams['groupId']

      this.ngxService.startLoader("groupMarksLoader");
      this.studentMarkService.getGroupMarks(this.groupId).subscribe(result => {
        this.ngxService.stopLoader("groupMarksLoader");
        this.groupMarks = result;
      });
    }

    deleteMark(markId: number){
      this.studentMarkService.deleteMark(markId).subscribe(result => {
        const removeIndex = this.groupMarks.findIndex( item => item.id === markId );
        this.groupMarks.splice( removeIndex, 1 );

        this.toastService.showSuccess("Mark deleted");
      });
    }
}