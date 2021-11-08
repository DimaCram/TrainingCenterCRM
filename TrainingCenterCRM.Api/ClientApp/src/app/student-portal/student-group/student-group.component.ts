import { Component } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { NgxUiLoaderService } from "ngx-ui-loader";
import { ToastService } from "src/app/components/toast/toast.service";
import { Material } from "src/app/models/metirial.model";
import { GroupService } from "src/app/services/group.service";
import { MaterialService } from "src/app/services/material.service";
import { saveAs } from 'file-saver';
import { Teacher } from "src/app/models/teacher.model";
import { StudentMarkService } from "src/app/services/student-mark.service";
import { ChartOptions, ChartType } from "chart.js";
import { Color, Label, MultiDataSet } from "ng2-charts";

@Component({
    selector: 'student-group',
    templateUrl: './student-group.component.html'
})

export class StudentGroupComponent{
    //chart settings
    maxMark = 10;
    public currentMark = 0;

    groupMaterials: Material[] = [];
    groupTeacher: Teacher;

    groupId: number;

    public pageStudent = 1;
    public pageMaterial = 1;
    public pageSize = 5;

    constructor(private materialService: MaterialService,
                private groupService: GroupService,
                private modalService: NgbModal,
                private route: ActivatedRoute,
                private router: Router,
                private ngxService: NgxUiLoaderService,
                private studentMarkService: StudentMarkService,
                private toastService: ToastService)
                {
                    this.groupId = +this.route.snapshot.queryParams['groupId']
                }

    ngOnInit(): void {

        this.ngxService.startLoader("materialsLoader");

        this.materialService.getMaterialsByGroup(this.groupId).subscribe(res => {
            this.ngxService.stopLoader("materialsLoader");
            this.groupMaterials = res;
        })

        this.ngxService.startLoader("teacherLoader");
        this.groupService.getGroupTeacher(this.groupId).subscribe(res => {
            this.ngxService.stopLoader("teacherLoader");
            this.groupTeacher = res;
        })

        this.studentMarkService.getStudentAverageByGroup(this.groupId).subscribe(res => {
            this.currentMark = +res.toFixed(2);
            this.initChart()
        })
    }

    downloadMaterialFile(fileId: number, fileName: string){

        this.materialService.downloadFile(fileId).subscribe(result => {
            var blob = new Blob([result]);
            saveAs(blob, fileName);
        });
    }

  // Doughnut
  public doughnutChartLabels: Label[] = [];
  public doughnutChartData: MultiDataSet = [];
  public doughnutChartType: ChartType = 'doughnut';
  public options: ChartOptions = {
    tooltips: {enabled: false},
  };
  public donutColors=[];

  initChart(): void{

    this.doughnutChartData = [
      [this.currentMark, this.maxMark - this.currentMark]
    ];

    let currentMarkColor = '';
    
    if(this.currentMark < 4){
      currentMarkColor = 'rgba(232, 86, 86)';
    }
    else if(this.currentMark >= 4 && this.currentMark < 8){
      currentMarkColor = 'rgb(223, 184, 28)';
    }
    else{
      currentMarkColor = '#90b900';
    }

    this.donutColors=[
      {
        backgroundColor: [ currentMarkColor, '#d3d3d3'],
        borderWidth: [0, 0]
      }
    ]
  }
}