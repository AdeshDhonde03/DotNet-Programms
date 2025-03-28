// let newElement=document.createElement("h1");
// newElement.textContent="Heading1";

// let boxElement=document.getElementsById("box");
// document.appendChild(newElement);

// boxElement.insertAdjacentElement("beforebegin",newElement);



// let secondParaElement=document.getElementById("para2");
// let boxElement=document.getElementById("box");
// //boxElement.removeChild(secondParaElement);

// // secondParaElement.remove();

// boxElement.style.backgroundColor="red";

// boxElement.style="background-color:yellow; color:red";


let personList=[
    {
        "name": "Adesh",
        "age" :23,
        "city":"pune"
    },
    {
        "name": "Yogendra",
        "age" :22,
        "city":"Ahilyanagar"
    },
    {
        "name": "prathmesh",
        "age" :21,
        "city":"pakistan"
    },
];
//Show all person in list
function showPerson(index,searchText)
{
let container=document.getElementById("Container");
container.innerHTML="";

 for(let i in personList)
 {

    let newElement=document.createElement("div");
    let innerHtmlString=`<ul>
        <li>name: ${personList[i].name}</li>
        <li>Age: ${personList[i].age}</li>
        <li>city:${personList[i].city}</li>
       </ul>
       <button onclick="deletePerson(${i})">Delete</button>  <button onclick="updatePerson(${i},0)">Update</button>`;
       if(index>=0 && index<personList.length && index==i)
       {
        innerHtmlString = `<ul>
        <li>name: <input type="text" id="updateName" value="${personList[i].name}"></li>
        <li>Age: <input type="number" id="updateAge" value="${personList[i].age}"</li>
        <li>city:<input type="text" id="updateCity" value="${personList[i].city}"</li>
       </ul>
       <button onclick="deletePerson(${i})">Delete</button>  <button onclick="updatePerson(${i},1)">Update</button>`;

       }
       newElement.innerHTML=innerHtmlString;
       container.appendChild(newElement);
       newElement.classList.add("personbox");
 }
}
showPerson(-1);
//Add person in list
function addPerson(){
    let name=document.getElementById("name").value;
    let age=document.getElementById("age").value;       
    let city=document.getElementById("city").value;

    personList.push({
        "name":name,
        "age":age,
        "city":city

    });
    console.log(personList);
    showPerson(-1);
}

//Remove person from list
function deletePerson(index)
{
    personList.splice(index,1);
    showPerson(-1);
}
//
function updatePerson(index,flag)
{
    if(flag==0)
    {
        showPerson(index);

    }else{
    let name=document.getElementById("updateName").value;
    let age=document.getElementById("updateAge").value;       
    let city=document.getElementById("updateCity").value;

    let person=personList[index];

    person.name=name;
    person.age=age;
    person.city=city;

    showPerson();

    }
}
function serachPerson()
{
    let searchText=document.getElementById("searchText").value;

}