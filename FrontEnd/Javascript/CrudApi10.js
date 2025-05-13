let employeeList = [];

async function fetchdata()
{
    let response = await fetch("http://localhost:5199/api/Employees");

    let data = response.json();
    employeeList = data;
}

let containerElement=document.getElementById("container");

async function showEmployees(flag = false,employeeId =-1)
{
    await fetchdata();

    let tableElement=document.createElement("table");
    tableElement.id = "table";
    tableElement.border= "1";

    tableElement.innerHTML=` <tr>
            <th>Employee Id</th>
            <th>Name</th>
            <th>Email</th>
            <th>Address</th>
            <th>Actions</th>
        </tr>`

        for(let i  in employeeList)
        {
            let employee=employeeList[i];

            let newElement = document.createElement("tr");

            let htmlString = `
                                <td>${employee.id}</td>
                                <td>${employee.name}</td>
                                <td>${employee.email}</td>
                                <td>${employee.address}</td>
                                <td>
                                   <button onclick="updateEmployee(true,${employee.employeeId}")>Update</button>
                                    <button onclick = "deleteEmployee(${employee.employeeId})">Delete</button>
                                </td>`
                             if(employee.employeeId && flag)
                             {
                                htmlString=`   
                                            <td>${employee.employeeId}</td>
                                            <td><input type="text" id="updatedName"  value=${employee.name}/></td>
                                            <td><input type="email" id="updatedEmail"  value=${employee.email}/></td>
                                            <td><input type="number" id="updatedSalary"  value=${employee.sa}/></td>
                                            <td>
                                                <button onclick="updateEmployee(false,${employee.employeeId}")>Update</button>
                                                <button onclick = "deleteEmployee(${employee.employeeId})">Delete</button>
                                            </td>`
                             }
            newElement.innerHTML=htmlString;
            tableElement.appendChild(newElement);
            
        }
        containerElement.appendChild(tableElement);


}

showEmployees();


async function addEmployee()
{
    let name = document.getElementById("name").value;
    let email = document.getElementById("email").value;
    let salary = Number(document.getElementById("salary").value);

    let employee={
        "name" :name,
        "email":email,
        "salary":salary
    };

    let options={
        "metod":"POST",
        "headers" :{
                       "Content-Type":"application/json"      
        },
        "body" : JSON.stringify(employee)
        
    };

    let response = await fetch(`http://localhost:5199/api/Employees`,options);
    await showEmployees();
}

async function deleteEmployee(employeeId)
{
    let options={
        "method":"DELETE"
    }

    let response = await fetch(`http://localhost:5199/api/Employees/${employeeId}`,options);
    await showEmployees();
}

async function updateEmployee(flag,employeeId) 
{
    if(flag)
    {
        await showEmployees(flag,employeeId)
    }else{
        let name = document.getElementById("updatedName").value;
        let email = document.getElementById("updatedName").value;
        let salary = document.getElementById("updatedSalary").value;

        let employee={
            "name" :name,
            "email":email,
            "salary":salary
        };

        let options = {
            "method":"PUT",
            "headers":{
                        "Content-Type":"application/json"
            },
            "body":stringify.JSON(employee)
        };

        let response = await fetch(`http://localhost:5199/api/Employees/${employee.employeeId}`,options);
        await showEmployees(false,-1);

    }
    
}