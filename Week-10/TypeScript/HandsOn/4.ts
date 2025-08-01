//functions
function Add(a:number,b:number)
{
    let result:number=a+b;
    console.log(`Addition of ${a} and ${b} :${result}`)
}
//calling function
Add(12,23);
//function with return value
function Greet(name:string)
{
    let msg:string='Hello '+name;
    return msg;
}
let result=Greet('Sourab')
console.log(result)
function Sqaure(no:number)
{
    let result=no*no;
    return result;
}
console.log(`Square of 5 is ${Sqaure(5)}`);