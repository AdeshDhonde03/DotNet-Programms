let employeeList=[];
let totalCount=0;
let totalPages=0;

async function loadData(pageNumber=1,pageSize=2,searchText="")
{
    let url;
    if(searchText ==="")
    {
        url = `http://localhost:5199/api/Employees?pageNumber=${pageNumber}&pageSize=${pageSize}`;
    }
    else{
          url = `http://localhost:5199/api/Employees?searchText=${searchText}&pageNumber=${pageNumber}&pageSize=${pageSize}`;
    }
    let response=fetch(url);
    let data=await response.json();

    employeeList=data.employees;

    totalPages=data.totalPages;
    totalCount=data.totalCount;

}
let containerElement=document.getElementById("container");

async function showEmployees(flag=false,employeeId=-1,pageNumber = 1,pageSize = 2 ,searchText = "")
{
    await loadData(pageNumber,pageSize,searchText)

    tableElement.innerHTML=``;
    let tableElement=document.createElement("table");
    tableElement.id="table";
    tableElement.border="1";

    tableElement.innerHTML=`<tr>
                <th>EmployeeId</th>
                <th>Name</th>
                <th>Email</th>
                <th>Salary</th>
                <th>Actions</th>
            </tr>`;
    
    for(let i in employeeList)
    {
        let employee=employeeList[i];
        let newElement=document.createElement("tr");

        let htmlString=`<td>${employee.employeeId}</td>
                        <td>${employee.name}</td>
                        <td>${employee.email}</td>
                        <td>${employee.salary}</td>
                        <td>
                            <button onclick=updateEmployee(true,${employee.employeeId},${pageNumber},${pageSize},${searchText})>Update</button>
                            <button onclick=deleteEmployee(${employee.employeeId},${pageNumber},${pageSize},${searchText})>Delete</button>
                        </td>`;
            
            if(employee.employeeId==employeeId && flag)
            {
                htmlString=`<td>${employee.employeeId}</td>
                            <td><input type="text" id="Updatedname" value="${employee.name}"></td>
                            <td><input type="email" id="Updatedemail" value="${employee.email}"></td>
                           <td><input type="number" id="Updatedsalalry" value="${employee.salary}"></td>
                            <td>
                                <button onclick=updateEmployee(false,${employee.employeeId},${pageNumber},${pageSize},${searchText})>Update</button>
                                <button onclick=deleteEmployee(${employee.employeeId},${pageNumber}, ${pageSize}, ${searchText})>Delete</button>
                            </td>`;
            }

            let prevButton=document.createElement("button");
            prevButton.innerHTML=`<`;
            containerElement.appendChild(prevButton);
            prevButton.addEventListener("click",()=>{
                let page=pageNumber - 1;
                if(page<1)
                {
                    page = 1;
                }
                showEmployees(flag = flag, employeeId = employeeId, pageNumber = page, pageSize = pageSize, searchText = searchText)

            });
            for(let i=1;i<=totalPages;i++)
            {
                let newButton=document.createElement("button");
                 newButton.innerHTML=`${i}`;
                 containerElement.appendChild(newButton);

                 newButton.addEventListener("click", () => {
                    showEmployees(flag = flag, employeeId = employeeId, pageNumber = i, pageSize = pageSize, searchText = searchText)

                 });
                
            }

            let nextButton=document.createElement("button");
            nextButton.innerHTML=`>`;
            containerElement.appendChild(nextButton);

            nextButton.addEventListener("click", ()=>{

                let page =pageNumber + 1;
                if(page>totalPages){
                    page=totalPages;
                }
                showEmployees(flag = flag, employeeId = employeeId, pageNumber = page, pageSize = pageSize, searchText = searchText)


            });
            

        newElement.innerHTML(htmlString);
        tableElement.appendChild(newElement);
    }
    containerElement.appendChild(tableElement);

}
showEmployees()

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
        "method":"POST",
        "headers": {
            "Content-Type":"application/json"
        },
        "body":JSON.stringify(employee)
    }

    let response=await fetch("http://localhost:5199/api/Employees",options);

    await showEmployees();
}

async function deleteEmployee(employeeId,pageNumber,pageSize,searchText)
{
    let options={
        "method":"DELETE",

    }
    let response= await fetch(`http://localhost:5199/api/Employees/${employeeId}`,options);

     //for pagination
     let newPageCount=Math.floor((totalCount - 1) % pageSize);
     if((totalCount - 1) % pageSize!=0)
     {
        newPageCount++;
     }
     if(pageNumber > newPageCount)
        {
            pageNumber=newPageCount;
        }
        await showEmployees(false,-1,pageNumber,pageSize,searchText);
    
    
}
async function updateEmployee(flag,employeeId,pageNumber,pageSize,searchText)
{
    if(flag)
    {
        await showEmployees(flag,employeeId,pageNumber,pageSize,searchText);
    }else{
        let name=document.getElementById("Updatedname").value;
        let email=document.getElementById("Updatedemail").value;
        let salary=Number(document.getElementById("Updatedsalary").value);

        let employee={
            "name":name,
            "email":email,
            "salary":salary

        }

        let options={
            "method":"PUT",
            "headers": {
            "Content-Type":"application/json"
        },
        "body":JSON.stringify(employee) 
        }

        let response=fetch(`http://localhost:5199/api/Employees/${employeeId}`,options);
        await showEmployees(false,-1,pageNumber,pageSize,searchText);
    }


}

async function searchEmployee()
{
    let searchText=document.getElementById("searchText").value;
    await showEmployees(false, -1, 1, 2, searchText);

}