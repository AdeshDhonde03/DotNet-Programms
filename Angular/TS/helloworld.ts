function Component(metadata : any){
    function ComponentDecorator(target :Function){
        console.log("This class is component class");
     }
     return ComponentDecorator;
}

function Input(metadata:any){
    function InputDecorator(target:any.property: string)
    {
        console.log(property);
    }
    return InputDecorator;
}
 
 @Component
 class Employees{
    employeeId:number;
    @Input({
        "greeting" : "Hello"
    })
    name:string;
    email:string;
    salary:number;

    constructor(employeeId:number,name:string,  email:string, salary:number){
        this.employeeId=employeeId;
        this.name=name;
        this.email=email;
        this.salary=salary;
        console.log("Constructor is called");
    }
}

var employee=new Employees(1,"Ram","ram@gmail.com",1000);
console.log(employee);