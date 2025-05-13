import React, { useEffect, useState } from 'react'

const EmployeeTable = () => {
 const[employeeList,setEmployeeList]=useState([]);
 const[pageNumber,SetPageNumber]=useState(1);
 const[pageSize,SetPagesize]=useState(2);
 const[totalPages,SetTotalPages]=useState(0);
 const[totaCount,Settotalcount]=useState(0);
 const[createEmployee,SetCreateEmployee]=useState({
    "name":"",
    "email":"",
    "salary":0
 });

 const[updateEMployeeId,setEmployeeId]=useState(-1);
 const[flag,setflag]=useState(false);
 const[updatedEmployeeData,setupdatedEmployeeData]=useState({
    "name":"",
    "email":"",
    "salary":0
 })

 //fetch data from backend
 async function fetchdata()
 {
    let response=await fetch(`https://localhost:7149/api/Employees?pageNumber=${pageNumber}&pageSize=${pageSize}`);
    let paginatedData=await response.json();

    setEmployeeList(paginatedData.employees);
    Settotalcount(paginatedData.totaCount);
    SetTotalPages(paginatedData.totalPages);
 }

 useEffect(()=>{
    fetchdata();
 },[]);

 //for Pagination
 let paginationArray=[];
 for(let i=1;i<=totalPages;i++)
 {
    paginationArray.push(i);
 }

 useEffect(()=>{
    fetchdata();
 },[pageNumber]);

 //Add Employees

 async function handleSubmit(e){
    e.preventDefault();

    let options={
        "method":"POST",
        "headers":{
            "Content-Type":"application/json"
        },
        "body":JSON.stringify(createEmployee)
    }
    let response=await fetch(`https://localhost:7149/api/Employees`,options);
    console.log(response);
    await fetchdata();
    SetPageNumber(totalPages);
    SetCreateEmployee({
        "name":"",
        "email":"",
        "salary":0
    });
    

 }
 function handleChange(e){
    SetCreateEmployee({...createEmployee,[e.target.name]:e.target.value});

 }
 
 
 //Delete Employee
 async function DeleteEmployee(employeeId){
    let options={
        "method":"DELETE"
    }
    let response=await fetch(`https://localhost:7149/api/Employees/${employeeId}`,options);
    let tc=totaCount-1;
    let tp=Math.ceil(tc/pageSize);

    if(pageNumber==totalPages && tp!=totalPages){
        SetPageNumber(tp);
    }
    await fetchdata();

 }

 //Update Employee
 async function updateEmployee(){
    let options={
        "method":"PUT",
        "headers":{
            "Content-Type":"application/json"
        },
        "body":JSON.stringify (updatedEmployeeData)
    }

    let response=await fetch(`https://localhost:7149/api/Employees/${updateEMployeeId}`,options);
    await fetchdata();

    setflag(false);
    setEmployeeId(-1);
    setupdatedEmployeeData({
        "name":"",
        "email":"",
        "salary":0
    });
   
 }

 function handleUpdate(e){
    setupdatedEmployeeData({...updatedEmployeeData,[e.target.name]:e.target.value})
 }


  return (
    <div>
        <form onSubmit={handleSubmit}>
            Enter Name:<input type="text" name='name' value={createEmployee.name} onChange={handleChange}/>
            Enter Email:<input type="email" name='email' value={createEmployee.email} onChange={handleChange}/>
            Enter Name:<input type="number" name='salary' value={createEmployee.salary} onChange={handleChange}/>
            <input type="submit" value="Add Employee"/>


        </form>
        <table>
            <tr>
                <th>EmployeeId</th>
                <th>Name</th>
                <th>Email</th>
                <th>Salary</th>
                <th>Actions</th>
            </tr>
            {
                employeeList.map((employee)=>{
                    let condition=setflag && updateEMployeeId==employee.employeeId
                    if(condition)
                    {
                        return(
                            <tr>
                                <td>{employee.employeeId}</td>
                                <td><input type="text" name='name' value={updatedEmployeeData.name} onChange={handleUpdate}/></td>
                                <td><input type="email" name='email' value={updatedEmployeeData.email} onChange={handleUpdate}/></td>
                                <td><input type="number" name='salary' value={updatedEmployeeData.salary} onChange={handleUpdate}/></td>
                                <td>
                                <button onClick={updateEmployee}>Update</button>
                                <button onClick={()=>
                                    DeleteEmployee(employee.employeeId)
                                }>Delete</button>
                            </td>
                            </tr>
                        )
                    }

                    return(
                        <tr>
                            <td>{employee.employeeId}</td>
                            <td>{employee.name}</td>
                            <td>{employee.email}</td>
                            <td>{employee.salary}</td>
                            <td>
                                <button onClick={()=>{
                                    setflag(true);
                                    setEmployeeId(employee.employeeId)
                                    setupdatedEmployeeData({
                                        "name":employee.name,
                                        "email":employee.email,
                                        "salary":employee.salary
                                    });
                                }}>Update</button>
                                <button onClick={()=>
                                    DeleteEmployee(employee.employeeId)
                                }>Delete</button>
                            </td>
                        </tr>
                    )
                })
                
                
            }
        </table>
        <div>
            {
                  paginationArray.map((num)=>{
                    return(
                        <button  onClick={() => {
                            SetPageNumber(num);
                        }}>{num}</button>
                    )
                    })
                
            }
        </div>
      
    </div>
    
  ) 
}

export default EmployeeTable
