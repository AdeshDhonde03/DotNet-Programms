let employeeList=[];

async function loaddata() {
    let response=await fetch("http://localhost:5199/api/Employees");

    employeeList=await response.json();
}


let tableElement=document.getElementById("table");

//Show Employee record
async function showEmployees(flag = false,employeeId =-1)
{
    await loaddata();

    tableElement.innerHTML=`<tr>
                <th>EmployeeId</th>
                <th>Name</th>
                <th>Email</th>
                <th>Salary</th>
                <th>Actions</th>
            </tr>`
 for(let i in employeeList)
 {
    let employee=employeeList[i];
    let newElement=document.createElement("tr");

    let htmlString=` <td>${employee.employeeId}</td>
                <td>${employee.name}</td>
                <td>${employee.email}</td>
                <td>${employee.salary}</td>
                <td>
                    <button onclick="UpdateEmployee(true,${employee.employeeId})">Update</button>
                    <button onclick="DeleteEmployees(${employee.employeeId})">Delete</button>
                </td>`;
    
    if(employee.employeeId == employeeId && flag)
    {
        htmlString=` <td>${employee.employeeId}</td>
                <td><input type="text" id="updatedName" value="${employee.name}"></td>
                <td><input type="email" id="updatedEmail" value="${employee.email}"></td>
                <td><input type="number" id="updatedSalary" value="${employee.salary}"></td>
                <td>
                    <button onclick="UpdateEmployee(false,${employee.employeeId})">Update</button>
                    <button onclick="DeleteEmployees(${employee.employeeId})">Delete</button>
                </td>`;
    }

    newElement.innerHTML=htmlString;
    tableElement.appendChild(newElement);

 }
}

showEmployees();

async function addEmployees()
{
    let name=document.getElementById("name").value;
    let email=document.getElementById("email").value;
    let salary=Number(document.getElementById("salary").value);

    let employee={
        "name":name,
        "email":email,
        "salary":salary
    }

    let options={
        "method" : "POST",
        "headers":{
            "Content-Type": "application/json"
        },
        "body":JSON.stringify(employee)
    }

    let response= await fetch("http://localhost:5199/api/Employees",options);
    console.log(response.status);

    await showEmployees();
}

//Update the record\

async function UpdateEmployee(flag,employeeId)
{
    if(flag)
    {
      await showEmployees(flag,employeeId);
    }else{
        let name=document.getElementById("updatedName").value;
        let email=document.getElementById("updatedEmail").value;
        let salary=Number(document.getElementById("updatedSalary").value);

        let employee={
            "name":name,
            "email":email,
            "salary":salary
        }

        let options={
            "method" : "PUT",
            "headers" :{
                "Content-Type": "application/json"
            },
            "body":JSON.stringify(employee)
        }
       let response= await fetch(`http://localhost:5199/api/Employees/${employeeId}`,options);

        await showEmployees(false,-1);
    
    }

}

//Delete employee recors
async function DeleteEmployees(employeeId)
{
    let options = {
        "method":"DELETE"
    }

    let response= await fetch(`http://localhost:5199/api/Employees/${employeeId}`,options);

    await showEmployees(false,-1);
    
}