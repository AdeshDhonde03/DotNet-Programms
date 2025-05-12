import { Component } from '@angular/core';
import { Students } from '../../Model/student';
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-student-crud',
  imports: [FormsModule],
  templateUrl: './student-crud.component.html',
  styleUrl: './student-crud.component.css'
})
export class StudentCrudComponent {
  students:Students[]=[];
  CreateStudentFormData : Students =new Students;
  setFlag:boolean=false;
  setUpdateId:number=-1;
  updateStudentFormData : Students =new Students;
  
  ngOnInit(){
  this.fethData();
 }

  async fethData(){
    let response=await fetch("https://localhost:7098/api/Student");
    let data=await response.json();
    console.log(data);
    this.students=data;

  }
  async addStudent()
  {
    let options={
      "method":"POST",
      "headers":{
        "Content-Type" : "application/json"
      },
      "body":JSON.stringify(this.CreateStudentFormData)
    }

    let response=await fetch(`https://localhost:7098/api/Student`,options);
    await this.fethData();
    this.CreateStudentFormData.name="";
    this.CreateStudentFormData.schoolName="";
    this.CreateStudentFormData.address="";

  }

  async deleteStudent(id:number)
  {
    let options={
      "method":"DELETE"
    };

    let response=await fetch(`https://localhost:7098/api/Student/${id}`,options);
    await this.fethData();

  }
  
  async updateStudent()
  {
    let options={
      "method":"PUT",
      "headers":{
        "Content-Type":"application/json"
      },
      "body":JSON.stringify(this.updateStudentFormData)

    };
    let response =await fetch(`https://localhost:7098/api/Student/${this.setUpdateId}`,options);

    await this.fethData();

    this.setFlag=false;
    this.setUpdateId=-1;
    this.updateStudentFormData.name="";
    this.updateStudentFormData.schoolName="";
    this.updateStudentFormData.address="";
    
  }
  addUpdateForm(student:Students){
    this.setFlag=true;
    this.setUpdateId=student.id;
    this.updateStudentFormData.name=student.name;
    this.updateStudentFormData.schoolName=student.schoolName;
    this.updateStudentFormData.address=student.address;

  }





}
