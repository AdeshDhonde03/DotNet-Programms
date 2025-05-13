// let inputTag=document.getElementById("age");
// console.log(inputTag.value);
function handleInput()
{
 let inputTag=document.getElementById('age');
 console.log(inputTag.value);
 inputTag.style.backgroundColor="aqua";

let age=inputTag.value;
console.log(age);
let errorpara=document.getElementById("errorMessage");
 if(age<0 || age>150)
 {
    errorpara.innerHTML="Age cannot be less than 0 or greater than 150";
    errorpara.style.display="block";
    errorpara.style.color="red";
 }else{
    // errorpara.style.display="none";
    if(age>=18){
        errorpara.innerHTML="You have voting rights";
        errorpara.style.color="green";
    }else{
        errorpara.innerHTML="You do not have voting rights";
        errorpara.style.color="red";
    }
 }
}