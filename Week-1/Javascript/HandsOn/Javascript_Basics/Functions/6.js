// let func=(arg1,arg2,....)=>expression
//const func=(arg1,arg2,....)=>expression
//arrow functions
// Arrow functions are a more concise syntax for writing functions in JavaScript.
// They are often used for short functions or callbacks.  
let Hello=()=>'Hello World'
let result=Hello();
console.log(result);
// Arrow functions can also take parameters
// They can be used in the same way as regular functions, but with a more concise syntax.
let Greet=(n)=>{
    let message='Hello '+n;
    return message;
}
console.log(Greet('Sachin'));
console.log(Greet('Dhoni'));
let sum=(a,b)=>a+b; // Arrow functions can also be used for simple expressions without curly braces
// In this case, the return statement is implicit.
console.log(sum(2,5));
let age=18;
let message=age>=18?()=>'you can vote':()=>'try next time'
console.log(message());
function f(f1,f2)
{
  //  console.log( f1()+' '+f2());
  return f1()+" "+f2();
}
result=f(()=>'Hello ',()=>'Tina')
console.log(result);
