let employeeList=[];

let totalCount=0;
let totalPages=0;


async function loadData(pageNumber,pageSize,searchText)
{
   let url;
   if(searchText==="")
   {
     url = `http://localhost:5199/api/Employees?pageNumber=${pageNumber}&pageSize=${pageSize}`
   }else{
    url = `http://localhost:5199/api/Employees?searchText=${searchText}&pageNumber=${pageNumber}&pageSize=${pageSize}`;
   }
      
    let response= await fetch(url);
    let paginatedData=await response.json();

    employeeList=paginatedData.employees;

    totalPages = paginatedData.totalPages;
    totalCount = paginatedData.totalCount;
}

let containerElement=document.getElementById("Container");

async function showEmployees(flag=false,employeeId=-1,pageNumber,pageSize,searchText)
{
    await loadData();

    containerElement.innerHTML=``;

    let tableElement=document.createElement("table");
    tableElement.id="table";
    tableElement.border="1";

    tableElement.innerHTML=` <tr>
            <th>EmployeeId</th>
            <th>Name</th>
            <th>Email</th>
            <th>salary</th>
            <th>Action</th>
        </tr>`;

        for(let i in employeeList)
        {
            let employee=employeeList[i];
            let newElement=document.createElement("tr");

            let htmlString=`<td>${employeeId}</td>
                            <td>${name}</td>
                            <td>${email}</td>
                            <td>${salary}</td>
                            <td>
                            <button onclick="updateEmployee(true,${employee.employeeId}, ${pageNumber}, ${pageSize}, ${searchText})">Update</button>
                            <button onclick="deleteEmployee(${employee.employeeId}, ${pageNumber}, ${pageSize}, ${searchText})">Delete</button>
                            </td>`;

                if(employee.employeeId==employeeId && flag)
                {
                    htmlString=`<td>${employee.em}</td>
                                <td><input type="text" id="updatedName" value=${employee.name}></td>
                                <td><input type="email" id="updatedEmail" value=${employee.email}></td>
                                 <td><input type="number" id="updatedSalary" value=${employee.salary}></td>
                                <td>
                                <button onclick="updateEmployee(false,${employee.employeeId}, ${pageNumber}, ${pageSize}, ${searchText})">Update</button>
                                <button onclick="deleteEmployee(${employee.employeeId}, ${pageNumber}, ${pageSize}, ${searchText})">Delete</button>
                                </td>`;
                }
            
            newElement.innerHTML=htmlString;
            tableElement.appendChild(newElement);
        }
        containerElement.appendChild(tableElement);

        //Add a previous button
        let prevButton=document.createElement("button");
        prevButton.innerHTML=`<`;
        containerElement.appendChild(prevButton);

        prevButton.addEventListener("click",()=>{
            let page=pageNumber-1;
            if(page<1){
                page=1;
            }
            showEmployees(flag=flag,employeeId=employeeId,pageNumber=page,pageSize=pageSize,searchText=searchText);
        });

        //Add middle/Display middle pagenumber
        for(let i=1;i<=totalPages;i++)
        {
            let newButton=document.createElement("button");
            newButton.innerHTML=`${i}`;
            containerElement.appendChild(newButton);

            newButton.addEventListener("")
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
    };

    let options={
        "method": "POST",
        "headers": {"Content-Type": "application/json"},
        "body": JSON.stringify(employee)
    }

    let response = await fetch("https://localhost:7149/api/Employees", options);
    console.log(response.status);

    await showEmployees();

}

async function deleteEmployee(employeeId)
{
    let options={
        "method":"DELETE"
    }

    let response= await fetch(`https://localhost:7149/api/Employees/${employeeId}`, options);

    await showEmployees();
}
async function updateEmployee(flag,employeeId)
{
    if(flag){
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
            "method": "PUT",
            "headers": {
                "Content-Type": "application/json"
            },
            "body": JSON.stringify(employee)
        }

        let response=await fetch(`https://localhost:7149/api/Employees/${employeeId}`, options);
        await showEmployees(false,-1);
    }

}