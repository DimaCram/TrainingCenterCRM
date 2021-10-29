import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { Group } from "src/app/models/group.model";
import { GroupService } from "src/app/services/group.service";

@Component({
    selector: 'teacher-groups',
    templateUrl: './teacher-groups.component.html'
})

export class TeacherGroupsComponent{
    teacherGroups: Group[] = [];
    public page = 1;
    public pageSize = 5;

    constructor(private titleService: Title,
                private groupService: GroupService,
                private ngxService: NgxUiLoaderService){}

    ngOnInit(): void {

        this.ngxService.startLoader("groupsLoader");

        this.groupService.getTeacherGroups().subscribe(res => {
            this.ngxService.stopLoader("groupsLoader");
            this.teacherGroups = res;
        })
    }

}