import React, { useEffect, useState } from 'react'

const StudentTable = () => {
    const[StudentList,setcreateStudentList]=useState([]);

    const[createStudentFormData,setcreateStudentFormData]=useState({
        "name":"",
        "schoolName":"",
        "address":""
    });
    const[updateFlag,setflag]=useState(false);
    const[updateId,setUpdateId]=useState(-1);
    const[updateformdata,setupdateFormData]=useState({
        "name":"",
        "schoolName":"",
        "address":""

    });

useEffect(()=>{
    fetchData();
},[]);
async function fetchData()
{
    let response=await fetch("https://localhost:7098/api/Student");
    let data=await response.json();
    setcreateStudentList(data);

}

async function addStudent(e)
{
    e.preventDefault();
    let options={
        "method":"POST",
        "headers":{
            "Content-Type":"application/json"
        },
        "body":JSON.stringify(createStudentFormData)
    };

    let response =await fetch(`https://localhost:7098/api/Student`,options);
    await fetchData();

    setcreateStudentFormData({
        "name":"",
        "schoolName":"",
        "address":""
    });
}
function handleChange(e)
{
    setcreateStudentFormData({...createStudentFormData,[e.target.name] : e.target.value});
}

async function deleteStudent(id)
{
    let options={
        "method":"DELETE"
    };
    let response =await fetch(`https://localhost:7098/api/Student/${id}`,options);
    await fetchData();
}
async function  updateStudent()
{
 let options={
    "method":"PUT",
    "headers":{
        "Content-Type":"application/json"
    },
    "body":JSON.stringify(updateformdata)
 };

 let response=await fetch(`https://localhost:7098/api/Student/${updateId}`,options);
 await fetchData();
 setUpdateId(-1);
 setflag(false);
 setupdateFormData({
    "name":"",
    "schoolName":"",
    "address":""
 });
}
function handleupdateChange(e){
    setupdateFormData[{...updateformdata,[e.target.name] : e.target.value}];
}

  return (
    <>
    <form onSubmit={addStudent}>
            Enter Name:<input type='text' name='name' value={createStudentFormData.name} onChange={handleChange}/><br />
            Enter Scool Name:<input type='text' name='schoolName' value={createStudentFormData.schoolName} onChange={handleChange}/><br />
            Enter Address:<input type='text' name='address' value={createStudentFormData.address} onChange={handleChange}/><br />
            <input type='submit' value="Add Student"/> 

        </form>
    <div>
         <table border={1}>
            <tr>
                <td>Student Id</td>
                <td>Student Name</td>
                <td>School Name</td>
                <td>Address</td>
                <td>Actions</td>
            </tr>
            {
                StudentList.map((student)=>{
                    let condition=setUpdateId && updateId==student.id
                    if(condition)
                    {
                        return(
                            <tr>
                                <td>{student.id}</td>
                                <td><input type="text" name='name' value={updateformdata.name} onChange={handleupdateChange}/></td>
                                <td><input type='text' name='shoolName' value={updateformdata.schoolName} onChange={handleupdateChange}/></td>
                                <td><input type='text' name='address' value={updateformdata.address} onChange={handleupdateChange}/></td>
                                <td>
                                    <button onClick={updateStudent}>Update</button>
                                    <button onClick={()=>{
                                        deleteStudent(student.id);
                                    }}>Delete</button>
                                </td>
                            </tr>
                            )
                    }
                    return(
                    <tr>
                        <td>{student.id}</td>
                        <td>{student.name}</td>
                        <td>{student.schoolName}</td>
                        <td>{student.address}</td>
                        <td>
                            <button onClick={()=>{
                                setflag(true);
                                setUpdateId(student.id);
                                setupdateFormData({
                                    "name":student.name,
                                    "schoolName":student.schoolName,
                                    "address":student.address
                                })

                            }}>Update</button>
                            <button onClick={()=>{
                                deleteStudent(student.id);
                            }}>Delete</button>
                        </td>
                    </tr>
                    )
                })
                
            }
        </table>
      
    </div>
    </>
  )
}

export default StudentTable
