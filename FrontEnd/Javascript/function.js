// // let ans=add(5,4);
// // console.log(ans);

// // prime number
// function isprime(num)
// {
//     if(num<2)
//     {
//         return false;
//     }
//     for(let i=2;i<num;i++)
//     {
//         if(num%i==0)
//         {
//             return false;
//         }
//     }
//     return true;
// }

// for(let i=1;i<=100;i++)
// {
//     if(isprime(i))
//     {
//         console.log(i);
//     }
// }

// let isprime1=isprime;
// console.log(isprime1(3));

// let add=(a,b)=>{
//     return a+b;
// }
// console.log(add(3,5));

let arr=[10,20,30,"hello","World",true,40,50];
function getNumber(val){
    if(typeof (val)=="number")
    {
        return val;
    }
}

arr.forEach(getNumber);
console.log(arr);