let personList = [
    {
        "name": "Ram",
        "age": 23,
        "city": "Pune"
    },
    {
        "name": "Shyam",
        "age": 21,
        "city": "Mumbai"
    },
    {
        "name": "Seeta",
        "age": 19,
        "city": "Nagpur"
    },
    {
        "name": "Geeta",
        "age": 18,
        "city": "Satara"
    }
]

let containerElement = document.getElementById("container");

//Show all persons in the list
function showPersons(index, searchText="",pageNumber=1,pageSize=2)
{

    containerElement.innerHTML = ""; 

    let filteredElemenyt=(person.name.toLowerCase().search(searchText.toLowerCase()) != -1)

    let fromIndex=(pageNumber-1) * pageSize;
    let toIndex=Math.min(fromIndex+pageSize-1,personList.length-1);
    let totalPages=Math.floor(personList.length / pageSize);
    if(personList.length % pageSize!=0){
        totalPages++;
    }

    for(let i in personList){
        let person = personList[i];
        
        //This condition is used to serach the person in the list
        //this condition is true then direct iterator go to the next iteration beacause of continue
        if(person.name.toLowerCase().search(searchText.toLowerCase()) == -1){
            continue;
        }

        //pageination
        if(!(i>=fromIndex && i<=toIndex))
        {
            continue;
        }

        let newElement = document.createElement("div");

        let htmlString = `<ul>
                <li>Name: ${person.name}</li>
                <li>Age:  ${person.age}</li>
                <li>City: ${person.city}</li>
            </ul><button onclick="deletePerson(${i})">Delete</button><button onclick="updatePerson(${i}, 0,${pageNumber})">Update</button>`
        
            //This condition is used to update records with the help of particular index
        if(index >= 0 && index < personList.length && index == i){
            htmlString = `<ul>
                <li>Name: <input type="text" id="updatedName" value="${person.name}"></li>
                <li>Age: <input type="number" id="updatedAge" value="${person.age}"></li>
                <li>City: <input type="text" id="updatedCity" value="${person.city}"></li>
            </ul><button onclick="deletePerson(${i})">Delete</button><button onclick="updatePerson(${i}, 1,${pageNumber})">Update</button>`
        }

        newElement.classList.add("personBox");

        newElement.innerHTML = htmlString;

        containerElement.appendChild(newElement);
    }
    //for button
    for(let i=1;i<=totalPages;i++)
    {
        let buttonElement=document.createElement("button");
        buttonElement.innerHTML=`${i}`;
        buttonElement.addEventListener("click",getPage)

        containerElement.appendChild(buttonElement);
    }

}

showPersons();
//Add person in the list
function addPerson(){
    let name = document.getElementById("name").value;
    let age = document.getElementById("age").value;
    let city = document.getElementById("city").value;

    personList.push({
        "name": name,
        "age": age,
        "city": city
    });
    showPersons();
}

//Delete person in the list
function deletePerson(index){
    personList.splice(index, 1);
    showPersons();
}

function updatePerson(index, flag,pageNumber){
    if(flag == 0){
        showPersons(index,searchText="",pageNumber=pageNumber,pageSize=2);
    }else{
        let name = document.getElementById("updatedName").value;
        let age = document.getElementById("updatedAge").value;
        let city = document.getElementById("updatedCity").value;

        let person = personList[index];
        person.name = name;
        person.age = age;
        person.city = city;
        showPersons(index,searchText="",pageNumber=pageNumber,pageSize=2);
    }
    
}
//Search person in the list
function searchPerson(){
    let searchText = document.getElementById("searchText").value;

    showPersons(-1, searchText);

}

function getPage(event)
{
    console.log(event.target.textContent);
    let pageNumber=Number(event.target.textContent);

    showPersons(-1,searchText="",pageNumber=pageNumber,pageSize=2);
}
