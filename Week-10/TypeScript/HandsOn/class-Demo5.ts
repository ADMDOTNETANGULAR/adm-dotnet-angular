class Calculate
{
    public Add(a:number,b:number):number//Add() returns a number
    {
        return a+b;
    }
    public Greet(name:string):string //Greet() returns a string
    {
        return 'Hello '+name
    }
    public GetFlowers():string[] //GetFlowers() returns an array of strings
    {
        return ["Rose","Lilly","Tulips"]
    }
}
let calc=new Calculate();
console.log(calc.Add(12,23))
console.log(calc.GetFlowers())
console.log(calc.Greet('Sachin'))