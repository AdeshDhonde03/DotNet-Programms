import React, { useEffect, useState } from 'react'

const EmployeeTable = () => {
    const[employeeList,setEmployeeList] = useState([]);
    const[pageNumber,setPageNumber]=useState(1);
    const[pageSize,setPageSize]=useState(2);
    const[totalCount,setTotalCount]=useState(0);
    const[totalPages,setTotalPages]=useState(0);
    const[createEmployeeFormData,setCreateEmployeeFormData]=useState({
            "name":"",
            "email":"",
            "salary":0
        });
    const[updateEmployeeFormData,setUpdateEmployeeFormData] = useState({
            "name":"",
            "email":"",
            "salary":0
    });
    const[flag,setFlag]=useState(false);
    const[UemployeeId,setemployeeId]=useState(-1);

    useEffect(()=>{
        fetchData();
    },[]);

    useEffect(()=>{
        fetchData();
    },[pageNumber]);


    async function fetchData()
    {
        let response=await fetch(`https://localhost:7149/api/Employees?pageNumber=${pageNumber}&pageSize=${pageSize}`);
        let paginatedData=await response.json();
        setEmployeeList(paginatedData.employees);
        setTotalCount(paginatedData.totalCount);
        setTotalPages(paginatedData.totalPages);
        
    }

    let paginationArray=[];
    for(let i=1;i<=totalPages;i++)
    {
        paginationArray.push(i);
    }

    //ADd employees

    async function handleSubmit(e)
    {
        e.preventDefault();
        let options={
            "method":"POST",
           "headers": {
                "Content-Type": "application/json"
            },
            "body": JSON.stringify(createEmployeeFormData)
        }

        let response=await fetch(`https://localhost:7149/api/Employees`,options);
        await fetchData();

        setPageNumber(totalPages);
        setCreateEmployeeFormData({
            "name":"",
            "email":"",
            "salary":0
        });

    }

    function handleChange(e){
        setCreateEmployeeFormData({...createEmployeeFormData,[e.target.name] : e.target.value});
 
    }

    //Delete Employee
    async function deleteEmployee(employeeId)
    {
        let options={
            "method":"DELETE"
        }
        let response=await fetch(`https://localhost:7149/api/Employees/${employeeId}`,options);
        let tc = totalCount - 1;
        let tp = Math.ceil(tc / pageSize);
        if(pageNumber == totalPages && tp != totalPages){
            setPageNumber(tp);
        }
        await fetchData();
    }

    //update employee record
    function handleUpdatedChange(e){
        setUpdateEmployeeFormData({...updateEmployeeFormData, [e.target.name]: e.target.value})
    }

    async function handleUpdate()
    {
        let options={
            "method":"PUT",
            "headers":{
                "Content-type":"application/json"
            },
            "body":JSON.stringify(updateEmployeeFormData)
        };
        let response=await fetch(`https://localhost:7149/api/Employees/${UemployeeId}`,options);
        await fetchData();
        setFlag(false);
        setemployeeId(-1);

        setUpdateEmployeeFormData({
            "name": "",
            "email": "",
            "salary": 0
        })
    }

  return (
    <div>
        <form onSubmit={handleSubmit}>
            <input type="text" name='name' placeholder='Enter a name' value={createEmployeeFormData.name}  onChange={handleChange}/><br />
            <input type="email" name='email' placeholder='Enter a email' value={createEmployeeFormData.email}  onChange={handleChange}/><br />
            <input type="number" name='salary' placeholder='Enter a salary' value={createEmployeeFormData.salary}  onChange={handleChange}/><br />
            <input type="submit" value="Add Employee" />
        </form>
        <table border={1}>
            <tr>
                <th>EmployeeId</th>
                <th>Name</th>
                <th>Email</th>
                <th>Salary</th>
                <th>Actions</th>
            </tr>
            
                {
                    employeeList.map((employee)=>{
                        let condition = setFlag && UemployeeId == employee.employeeId;
                        if(condition){
                        return(
                        <tr>
                        <td>{employee.employeeId}</td>
                        <td><input type="text" name='name' value={updateEmployeeFormData.name} onChange={handleUpdatedChange}/></td>
                        <td><input type="email" name='email' value={updateEmployeeFormData.email} onChange={handleUpdatedChange}/></td>
                        <td><input type="number" name='salary' value={updateEmployeeFormData.salary} onChange={handleUpdatedChange}/></td>
                        <td>
                            <button onClick={handleUpdate}>Update</button>
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
                                    setemployeeId(employee.employeeId);
                                    setUpdateEmployeeFormData({
                                        "name": employee.name,
                                        "email": employee.email,
                                        "salary": employee.salary
                                    });
                                }}>Update</button>
                                <button onClick={()=>
                                    deleteEmployee(employee.employeeId)
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

export default EmployeeTable
