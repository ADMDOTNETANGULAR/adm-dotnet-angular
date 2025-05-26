function Square(n)
{
    let result=n*n;
    return result;
}
function Greet(name)
{
    let message='Hello '+name;
    return message;
}
function IsEven(number)
{
   //let isEven=number%2==0?true:false;
//    if(number%2==0)
//    return true;
//    else
   return false;
    //return isEven;
}
let result=Square(10);
console.log(result);
result=Greet('Dhoni');
console.log(result);
console.log(IsEven(110)==true?'Even':'Odd');
