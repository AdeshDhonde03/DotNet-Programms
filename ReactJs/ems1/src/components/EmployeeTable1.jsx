import React, { useEffect, useState } from 'react'

const EmployeeTable1 = () => {
 const[employeeList,setEmployeeList]=useState([]);
 const[pageNumber,setPageNumber]=useState(1);
 const[pageSize,setpagesize]=useState(2);
 const[totalCount,setTotalCount]=useState(0);
 const[totalPages,setTotalPages]=useState(0);
 const[createEmployeeFormData,setCreateEmployeeFormData]=useState({
    "name":"",
    "email":"",
    "salary":0
 });
 const[updatedEmployeeId,setUpdatedEmployeeId]=useState(-1);
 const[flag,setFlag]=useState(false);
 const[updateEmployeeFormData,setUpdateEmployeeFormData]=useState({
    "name":"",
    "email":"",
    "salary":0
 })

 //fetch data from backend

 useEffect(()=>{
    fetchData();
 },[]);

 async function fetchData(){
   let response=await fetch(`https://localhost:7149/api/Employees?pageNumber=${pageNumber}&pageSize=${pageSize}`);
   let paginatedData=await response.json();
   setEmployeeList(paginatedData.employees);
   setTotalCount(paginatedData.totalCount);
   setTotalPages(paginatedData.totalPages);
 }
//for pagination
useEffect(()=>{
    fetchData();
},[pageNumber]);

 let paginationArray=[];
 for(let i=1;i<=totalPages;i++)
 {
    paginationArray.push(i);
 }

 //Add Employees


async function handlesubmit(e){
    e.preventDefault();

    let options={
        "method":"POST",
        "headers":{
            "content-Type":"application/json"
        },
        "body":JSON.stringify(createEmployeeFormData)

    }
       let response =await fetch(`https://localhost:7149/api/Employees`,options);
       await fetchData();

       setPageNumber(totalPages);
       setCreateEmployeeFormData({
        "name":"",
        "email":"",
        "salary":0
       });

}
function handleChange(e){
    setCreateEmployeeFormData({...createEmployeeFormData,[e.target.name]:e.target.value});
}
//for delete Employee in recoprds
async function deleteEmployee(employeeId)
{
    let options={
        "method":"DELETE"
    }
    let respponse=await fetch(`https://localhost:7149/api/Employees/${employeeId}`,options);
    let tc=totalCount-1;
    let tp=Math.ceil(tc/pageSize);

    if(pageNumber==totalPages && tp!=totalPages){
        setPageNumber(tp);
    }
    await fetchData();
}
//for Update A employee 
async function update(){
    let options={
        "method":"PUT",
        "headers":{
            "content-Type":"application/json"
        },
        "body":JSON.stringify(updateEmployeeFormData)

    };

    let response= await fetch(`https://localhost:7149/api/Employees/${updatedEmployeeId}`,options);
    setFlag(false);
    setUpdatedEmployeeId(-1);
    setUpdateEmployeeFormData({
        "name":"",
        "email":"",
        "salary":0
    });
    await fetchData();

}

function handleUpdatedChange(e){
    setUpdateEmployeeFormData({...updateEmployeeFormData, [e.target.name]: e.target.value});
}


 return (
    <div>
        <form onSubmit={handlesubmit}>
            Enter Name:<input type="text" name='name' value={createEmployeeFormData.name} onChange={handleChange}/><br />
            Enter Email:<input type="email" name='email' value={createEmployeeFormData.email} onChange={handleChange}/><br />
            Enter Salary:<input type="number" name='salary' value={createEmployeeFormData.salary} onChange={handleChange}/><br />
            <input type="submit" value="Add Employees"/>
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
            let condition=setFlag && updatedEmployeeId==employee.employeeId
            if(condition)
            {
                return(
                    <tr>
                            <td>{employee.employeeId}</td>
                            <td><input type="text" name='name' value={updateEmployeeFormData.name} onChange={handleUpdatedChange}/></td>
                            <td><input type="email" name='email' value={updateEmployeeFormData.email} onChange={handleUpdatedChange}/></td>
                            <td><input type="number" name='salary' value={updateEmployeeFormData.salary} onChange={handleUpdatedChange}/></td>
                            <td>
                                <button onClick={update}>Update</button>
                                <button onClick={()=>
                                    deleteEmployee(employee.employeeId)
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
                                setFlag(true);
                                setUpdatedEmployeeId(employee.employeeId)
                                setUpdateEmployeeFormData({
                                    "name":employee.name,
                                    "email":employee.email,
                                    "salary":employee.salary
                                    
                                });
                            }
                            }>Update</button>
                            <button onClick={()=>{
                               deleteEmployee(employee.employeeId)
                            }}>Delete</button>
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
                    <button style={{"backgroundColor" : (pageNumber==num) ? "green" : "grey" }} onClick={() => {
                        setPageNumber(num);
                    }}>{num}</button>
                )
            })
        }
     </div>
    </div>
  )
}

export default EmployeeTable1
