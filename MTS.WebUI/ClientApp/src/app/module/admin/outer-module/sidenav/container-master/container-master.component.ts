import { Component,OnInit } from '@angular/core';
import { EmployeesService } from './employees.service';
import { Employees } from './employee.model';
@Component({
  selector: 'app-container-master',
  templateUrl: './container-master.component.html',
  styleUrls: ['./container-master.component.css']
})
export class ContainerMasterComponent implements OnInit {
  employees1: Employees[] = [];
  constructor(private employeesService: EmployeesService) { }
  ngOnInit(): void {
    this.employeesService.getAllEmployees1().subscribe({
      next: (employees1) => {
        console.log(employees1)
      },
      error: (response) => { 
        console.log(response);
      }
    })
  }
}

