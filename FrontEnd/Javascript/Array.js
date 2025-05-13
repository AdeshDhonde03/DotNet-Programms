// let arr=[10,20,30,"hello","world",true,40,50];
// console.log(arr.indexOf("hello"));
// console.log(arr.concat([10,20,30]));
// console.log

// let arr=[10,20,30,40,50,60,70];
// function filterArray(brr,func)
// {
//     let crr=[];
//     for(let i of brr){
//         if(func(i)){
//             crr.push(i);
//         }
//     }
//     return crr; 
// }
// let ans=filterArray(arr,(x)=>x>40);
// console.log(ans.splice(1,2,30));
// console.log(ans);

// let arr={
//     0:10,
//     1:20,
//     2:30,
//     3:40,
//     4:50,
//     5:60,
//     6:70,
//     7:80,
//     filter:function(func)
//     {
//         let crr=[];
//             for(let key in  arr){
//                 if(func(arr[key])){
//                     crr.push(arr[key]);
//                 }
//             }
//             return crr;    
//     }
// }
// console.log(arr["filter"]>30);
// let ans=arr.filter((x)=>x>30)

// console.log(ans);

function add(num1=10,num2=12)// we can pass default values in function
{
    console.log(num1+num2);
}
add(3,4);