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
    private teacherGroups: Group[] = [];
    public filteredTeacherGroups: Group[] = [];

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
            this.filteredTeacherGroups = res;
        })
    }

    search(searchText: string){
        this.filteredTeacherGroups = this.teacherGroups.filter(group => {
          const term = searchText.toLowerCase();
          return group.name.toLowerCase().includes(term)
              || group.startDate.toString().includes(term)
              || group.course.title.toLowerCase().includes(term);
        });
      }
}