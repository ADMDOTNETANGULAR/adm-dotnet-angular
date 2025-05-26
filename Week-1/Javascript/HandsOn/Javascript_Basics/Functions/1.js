function Hello()
{
    console.log('Hello World..');
}
//calling function
Hello();
function Greet(name)
{
    Hello();
    console.log(`Hello ${name}`)

}
Greet('Sachin');
Greet('Rahul');
function Add(a,b)
{
    let result=a+b;
    console.log(`${a}+${b}=${result}`)
}
Add(3,5);
function Sum(a,b=10) //defaut value of b=10
{
    let result=a+b;
    console.log(`${a}+${b}=${result}`)
}
Sum(12);
Sum(13,20);