import React, { useEffect, useState } from 'react'

const Company = () => {
    const[companyList,setCompanyList]=useState([]);
    const[createCompanyForm,setCompanyForm]=useState({
        "name":"",
        "address":""
    });
    const[updatedId,SetupdatedId]=useState(-1);
    const[updateFlag,SetFlag]=useState(false);
    const[updateCompanyForm,setupdateCompanyForm]=useState({
        "name":"",
        "address":""
    });


    useEffect(()=>{
        fetchData();
    },[]);
    async function fetchData()
    {
        let response=await fetch("http://localhost:5091/api/Company/list");
        let data=await response.json();
        console.log(data);
        setCompanyList(data);

    }

    //Add Company
    async function AddComapany(e)
    {
        e.preventDefault();
        let options={
            "method" : "POST",
            "headers" :{
                "Content-Type":"application/json"
            },
            "body":JSON.stringify(createCompanyForm)
        }

        let response=await fetch(`http://localhost:5091/api/Company/Create`,options);
        fetchData();
        setCompanyForm({
            "name":"",
            "address":""
        });
    }
    function handleChange(e){
        setCompanyForm({...createCompanyForm,[e.target.name]:e.target.value});
    }

    //Delete Company
    async function deleteCompany(id)
    {
        let options={
            "method":"DELETE"
        };

        let response=await fetch(`http://localhost:5091/api/Company/delete/${id}`,options);

        if(response.ok()){
            await fetchData();
        }
    }

    //Update Compnay Recordss
    async function updateCompany()
    {
        let options={
            "method" :"PUT",
            "headres":{
                "Content-Type":"application/json"
            },
            "body":JSON.stringify(updateCompanyForm)
        };

        let response=await fetch(`http://localhost:5091/api/Company/update/${updatedId}`,options);
         await fetchData();
         SetFlag(false);
         SetupdatedId(-1);

         setupdateCompanyForm({
            "name":"",
            "address":""
         });
    }

    function handleUpdate(e)
    {
        setupdateCompanyForm({...updateCompanyForm,[e.target.name] : e.target.value});
    }


  return (
    <>
    <form onSubmit={AddComapany}>
        Enter Company Name:   <input type='text' name='name' value={createCompanyForm.name} onChange={handleChange}/><br />
        Enter Company Address:<input type='text' name='address' value={createCompanyForm.address} onChange={handleChange}/><br />
        <input type='submit' value="Add Company"/>
    </form>

    <br />  
    <div>
        <table border={1}>
            <tr>
                <th>Company Id</th>
                <th>Name</th>
                <th>Address</th>
                {/* <th>UpdatedBy</th>
                <th>UpdateOn</th>
                <th>CreatedBy</th>
                <th>CreatedOn</th>
                <th>Createdby</th>
                <th>IsActive</th> */}

                <th>Actions</th>
            </tr>
            {
                companyList.map((company)=>{
                    let condition= SetFlag && Number(company.id == updatedId);

                    if(condition)
                    {
                        return(
                            <tr>
                                <td>{company.id}</td>
                                <td><input type='text' name='name' value={updateCompanyForm.name} onChange={handleUpdate}/></td>
                                <td><input type='text' name='address' value={updateCompanyForm.address} onChange={handleUpdate}/></td>
                                <td>
                                <button onClick={updateCompany}>Update</button>
                                <button>Delete</button>
                            </td>
                            </tr>
                        )
                    }
                    return(
                        <tr>
                            <td>{company.id}</td>
                            <td>{company.name}</td>
                            <td>{company.address}</td>
                            {/* <td>{company.updatedBy}</td>
                            <td>{company.updatedOn}</td>
                            <td>{company.createdBy}</td>
                            <td>{company.createdOn}</td>
                            <td>{company.isActive}</td> */}
                            <td>
                                <button onClick={()=>{
                                    SetFlag(true);
                                    SetupdatedId(Number(company.id));
                                    setupdateCompanyForm({
                                        "name":company.name,
                                        "address":company.address

                                    });
                                }}>Update</button>
                                <button onClick={()=>{
                                    deleteCompany(Number(company.id))
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

export default Company
