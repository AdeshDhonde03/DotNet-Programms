// async function printNumbers()
// {
//     await setTimeout(function(){
//         console.log("set timeout");
//     },10000);
//     for(let i=0;i<=1000;i++)
//     {
//         console.log(i);
//     }
//     return 100;
// }

// let a=printNumbers();

// console.log(a);
// 
// let promise=new Promise( function(resolve,reject){
//     console.log("Hello World");

   
//     let flag=true;
//     if(flag){
//         resolve("Sucess");
//     }else{
//         reject("Failure");
//     }
// })


// console.log(promise);
// let b=promise.then(function(a){
//     console.log(a);
//     return "Hello";

// }).then(function(c){
//     console.log(c);
// }).catch(function(b){
//     console.log(b);
// }).finally(function(){
//     console.log("end");
// })

// console.log(b);



//Fetch a data from backend help of try and catch

// let promise=fetch("https://localhost:7149/api/Employees");

// promise.then(function(response){
//     console.log(response);
//     return response.json();
// }).then(function(data){
//     console.log(data);
// }).catch(function(e){
//     console.log(e);
// })



//Very Important

//Fetch a data from backend help of async and await method
async function loaddata() 
{
   
//  let promise=fetch("https://localhost:7149/api/Employees");
//  let response=await promise;
//  console.log((await promise).status);

//  let promise1=response.json();

//  let data=await promise1;
//  console.log(data);


// second and simple Method Method
let response=await fetch("https://localhost:7149/api/Employees");
console.log(response);
console.log(response.status);

let data=await response.json();
console.log(data);
    
}
    loaddata();
