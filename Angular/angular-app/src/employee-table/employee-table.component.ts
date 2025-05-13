import { Component, SimpleChanges } from '@angular/core';
import { Employee } from './Models/employee';
import {FormsModule} from '@angular/forms';


@Component({
  selector: 'app-employee-table',
  imports: [FormsModule],
  templateUrl: './employee-table.component.html',
  styleUrl: './employee-table.component.css'
})
export class EmployeeTableComponent {
  employees:Employee[]=[];
  pageNumber:number=1;
  pageSize:number=2;
  totalCount:number=0;
  totalPages:number=0;
  searchText:string="";
  paginateArray:number[]=[];
  createEmployeeFormData:Employee=new Employee;
  updateEmployeeFlag:boolean=false;
  updateEmployeeId:number=-1;
  updateEmployeeFormData:Employee=new Employee;

  ngOnInit(){
    this.fetchData();
    
  }

  ngOnChange(pageNumber: SimpleChanges){
  
  }
  async fetchData(){
    let url=`https://localhost:7149/api/Employees?pageNumber=${this.pageNumber}&pageSize=${this.pageSize}`;
    if(this.searchText !==""){
     url=`https://localhost:7149/api/Employees?pageNumber=${this.pageNumber}&pageSize=${this.pageSize}&searchText=${this.searchText}`;
    }
    let response=await fetch(url);
    let paginatedData= await response.json();

   this.employees=paginatedData.employees;
   this.totalCount=paginatedData.totalCount;
   this.totalPages=paginatedData.totalPages;

   this.paginateArray=[];
   for(let i=1;i<=paginatedData.totalPages;i++)
   {
    this.paginateArray.push(i);
   }
   
  }

  handlePagination(page:number){
    this.pageNumber=page;
    this.fetchData();
  }

  async createEmployee(){
    let options={
      "method":"POST",
      "headers":{
        "content-Type": "application/json"
      },
      "body":JSON.stringify(this.createEmployeeFormData)
    };

    await fetch(`https://localhost:7149/api/Employees`,options);
    this.pageNumber=this.totalPages;
    if(this.totalCount+1 > this.pageNumber *this.pageSize)
    {
      this.pageNumber++;
    }
    await this.fetchData();
    this.createEmployeeFormData.name="";
    this.createEmployeeFormData.email="";
    this.createEmployeeFormData.salary=0;

  }

  async deleteEmployee(employeeId:number)
  {
    let options={
      "method":"DELETE",
      
    }
    let response=await fetch(`https://localhost:7149/api/Employees/${employeeId}`,options);
    if(this.totalCount -1 ==(this.pageNumber-1)*this.pageSize && this.pageNumber!=1){
      this.pageNumber--;
    }
    
    await this.fetchData();
    
  }

 async updateEmployee(){
    let options={
      "method":"PUT",
      "headers":{
        "Content-Type":"application/json"
      },
      "body":JSON.stringify(this.updateEmployeeFormData)
    }
    let response=await fetch(`https://localhost:7149/api/Employees/${this.updateEmployeeId}`,options);
    await this.fetchData();
    this.updateEmployeeFlag=false;
    this.updateEmployeeId=-1;
    this.updateEmployeeFormData.name="";
    this.updateEmployeeFormData.email="";
    this.updateEmployeeFormData.salary=0;
 }

 addUpdateForm(employee:Employee){
  this.updateEmployeeFlag=true;
  this.updateEmployeeId=employee.employeeId;
  this.updateEmployeeFormData.name=employee.name;
  this.updateEmployeeFormData.email=employee.email;
  this.updateEmployeeFormData.salary=employee.salary;

 }

}
