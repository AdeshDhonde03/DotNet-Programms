// let i=1;
// let sum=0;
// while(i<=100)
// {
//     // console.log("Hello");
//     // if(i%2==0)
//     // {
//     //     console.log("World");
//     // }
//     // i++;
//     sum+=i;
//     i++;
// }
// console.log(sum);

//Factorial of number

// let n=5;
// let i=1;
// let fact=1;


// while(i<=n)

// {
//   fact=fact*i;
//   i++;

// }
// console.log(fact);

//power
// let  x=2;
// let  number=5
// let total=1
// let i=1
// while(i<number)
// {
//  total=total*2;
//  i++;

// }
// console.log(total);

// let x=2;
// let n=5;
// let fact=1;
// let pow=1;
// let sum=0;
// let i=1;
// while(i<=n)
// {
//     fact=fact*x;
//     pow=pow*i;
//     if(i%2==0)
//     {
//         sum=sum-pow/fact;
//     }
//     else{
//         sum=sum-pow/fact;
//     }
//     i++;
// }
// console.log(sum);


//Array
//Find maximum and minimum number in the array
// let arr=[-1,10,7,11,9,13];
// let i=0;
// let max=Number.MIN_VALUE;
// let min=Number.MAX_VALUE;

// while(i<arr.length)
// {
//     if (arr[i]>=max)
//     {
//         max=arr[i];
//     }
//     if(arr[i]<=min)
//     {
//         min=arr[i];
//     }
// i++;
// }
// console.log(min);
// console.log(max);


//For Loop

// for(let i=1;i<=100;i++)
// {
//     console.log(i);
// }

//Reverse a number
// let number=12345;
// let rev=0;
// let rem=0;
// for(;number!=0;number=Math.floor(number/10))
// {
//     rem=number%10;
//     rev=rev*10+rem;
// }
// console.log(rev);

// let person={
//     "name":"Ram",
//     "age":23,
//     "city":"pune"
// }
// for(let key in person)// for in loop
// {
//     console.log(key+ " :"+person[key]);
// }
// let arr=[10,20,30,40,"Hello"];
// for(let i in arr)  //operatins on index/object
// {
//     console.log(arr[i]);
// }

//For of loop

// let arr=[10,20,30,40,50,"hello"];
// for(let num of arr) //It gives direct values not index
//     {
//     console.log(num);
// }



//Do while loop

// let i=1;
// do{
//    console.log(i);
//    i++;
// }while(i<10)


let person=
[
{
    "name":"Ram",
    "age":22,
    "city":{
        "permanent":{
            "villageorCity":"walki",
            "taluka":"nagar",
            "district":"a.nagar",
            "pincode":414006

        },
        "Temprory":{
           "villageorCity":"walki",
            "taluka":"nagar",
            "district":"a.nagar",
            "pincode":414006

        }
    }
    },
    {
    "name":"Ram",
    "age":22,
    "city":{
        "permanent":{
            "villageorCity":"walki",
            "taluka":"nagar",
            "district":"a.nagar",
            "pincode":414006

        },
        "Temprory":{
           "villageorCity":"walki",
            "taluka":"nagar",
            "district":"a.nagar",
            "pincode":414006

        }
    }
    },
    {
    "name":"Ram",
    "age":22,
    "city":{
        "permanent":{
            "villageorCity":"walki",
            "taluka":"nagar",
            "district":"a.nagar",
            "pincode":414006

        },
        "Temprory":{
           "villageorCity":"walki",
            "taluka":"nagar",
            "district":"a.nagar",
            "pincode":414006

        }
    }
    },

]
let result=[];
let i=0
for(let obj of person)
{
   result.push(obj["city"]["Temprory"]);
   console.log(result[i]);
   i++;
}