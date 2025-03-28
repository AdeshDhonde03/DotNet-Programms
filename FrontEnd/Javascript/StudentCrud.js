studentList=[];

async function loadData()
{
    let response= await fetch("http://localhost:5032/api/Employees");
    let data=response.json();
    studentList=data.students;
}

let containerElement=document.getElementById("container");
async function showStudents(flag,id)
{
  await loadData();
  containerElement.innerHTML=``;
  let tableElement=document.createElement("table");
  tableElement.id="table";
  tableElement.border="1";

  tableElement.innerHTML=` <tr>
        <th>Id</th>
        <th>Name</th>
        <th>Email</th>
        <th>Number</th>
        <th>Actions</th>
    </tr>`

    for(let i in studentList){
        let student=studentList[i];
        let newElement=document.createElement("tr");

        let htmlString=`
        <td>${student.id}</td>
        <td>${student.name}></td>
        <td>${student.email}</td>
        <td>${student.Number}</td>
        <td>
        <button onclick="updateStudent(true,${student.id})">Update</button>
        <button onclick="deleteStudent(true,${student.id})">Delete</button>
        </td>`;

        if(student.id==id && flag)
        {
            htmlString=`<td>${student.id}</td>
                <td><input type="text" id="updatedName" value="${student.name}"></td>
                <td><input type="email" id="updatedEmail" value="${student.email}"></td>
                <td><input type="number" id="updatedNumber" value="${student.number}"></td>
                <td>
                <button onclick="updateStudent(false,${student.id})">Update</button>
                <button onclick="deleteStudent(${student.id})">Delete</button>
                </td>`;
                
        }

        newElement.innerHTML=htmlString;
        tableElement.appendChild(newElement);
    }
    containerElement.appendChild(tableElement);

}
showStudents();

async function addStudents()
{
    let name=document.getElementById("name").value;
    let email=document.getElementById("email").value;
    let number=Number(document.getElementById("number").value);

    let student={
        "name":name,
        "email":email,
        "number":number
    }

    let options={
        "method":"POST",
        "headers": {
            "content-Type": "application/json"
        },
        "body": JSON.stringify(student)
    }
    let response=await fetch("http://localhost:5032/api/Employees",options);
    console.log(response.status);
    await showStudents();
}

async function deleteStudent(id)
{
    let options={
        "method":"DELETE"
    }
    let response=await fetch(`http://localhost:5032/api/Employees/${id}`,options);

    await showStudents();
}
async function updateStudent(flag,id)
{
    if(flag)
    {
        await showStudents(flag,id);
    }else{
        let name=document.getElementById("updatedName").value;
        let eamil=document.getElementById("updatedEmail").value;
        let number=Number(document.getElementById("updatedNumber").value);

        let student={
            "name":name,
            "email":email,
            "number":number
        }

        let options={
            "method":"PUT",
            "headers": {
            "content-Type": "application/json"
         },
         "body": JSON.stringify(student)

        }

        let response=await fetch(`http://localhost:5032/api/Employees/${id}`,options);
        await showStudents();

    }

}