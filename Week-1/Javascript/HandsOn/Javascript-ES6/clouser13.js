function greeting(message)
{
    return (name)=>{
        return message+" "+name;
    }
}
let SayHi=greeting('Hi');
let SayHello=greeting('Hello');
console.log(SayHi('Vikram'));
console.log(SayHello('Monica'));