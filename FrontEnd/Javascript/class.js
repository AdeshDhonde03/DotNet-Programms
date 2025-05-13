class Person{
    name;
    age;
    height;
    weight;

    constructor(name,age,height,weight)
    {
        this.name=name;
        this.age=age;
        this.height=height;
        this.weight=weight;
    }
     print()
    {
        console.log(this.name+"," +this.age+","+this.height+"," +this.weight);
        
    }

}
let person=new Person("Adesh",27,171,70);