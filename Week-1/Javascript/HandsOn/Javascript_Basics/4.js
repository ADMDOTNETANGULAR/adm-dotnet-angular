if(true)
{
    var test=true;
}
console.log(test); //the variable test lives after the block.
if(true)
{
    let test1=false;
}
//console.log(test1); exception
function f()
{
    if(true)
    {
        var msg='hi';
    }
    console.log(msg);
}
f();
//console.log(msg);
function f1()
{
    var msg='Hi';
}
f1();
//console.log(msg);

// let user='Hari';
// let user='Jeson';
// console.log(user);
var user='Hari';
var user="Jeson";
console.log(user);