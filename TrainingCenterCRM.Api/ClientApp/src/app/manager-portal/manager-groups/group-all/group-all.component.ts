import { Component } from "@angular/core";
import { Title } from "@angular/platform-browser";
import { Group } from "src/app/models/group.model";
import { GroupService } from "src/app/services/group.service";
import { TeacherService } from "src/app/services/teacher.service";

@Component({
    selector: 'manager-group-all',
    templateUrl: './group-all.component.html'
})


export class GroupAllComponent{
    public groups: Group[] = [];
    public page = 1;
    public pageSize = 5;

    constructor(private groupService: GroupService,
                private titleService: Title){}

    ngOnInit(): void {
      this.titleService.setTitle("Groups - Training Center")

      this.groupService.getGroups().subscribe(result => {
        this.groups = result;
      });
    }

    deleteGroup(id: number){

      this.groupService.deleteGroup(id).subscribe(result => {
        const removeIndex = this.groups.findIndex( item => item.id === id );
        this.groups.splice( removeIndex, 1 );
      });
    }
}