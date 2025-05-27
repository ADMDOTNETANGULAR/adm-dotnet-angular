//functions are reusable blocks of code
// Functions can be defined in different ways in JavaScript
function Hello()
{
    //function body
    //function body is a block of code that runs when the function is called
    console.log('Hello World..');
}
//calling function
Hello();
//function with parameters
// A function can take parameters, which are values passed to the function when it is called
function Greet(name)
{
    Hello();//calling another function
    console.log(`Hello ${name}`)

}
Greet('Sachin');
Greet('Rahul');
function Add(a,b)   //function with parameters  
{
    let result=a+b; //adding two numbers
    //result is a local variable, it is not accessible outside this function
    console.log(`${a}+${b}=${result}`)
}
Add(3,5);
function Sum(a,b=10) //defaut value of b=10
{
    let result=a+b;
    console.log(`${a}+${b}=${result}`)
}
Sum(12);// b will take default value 10
Sum(13,20);