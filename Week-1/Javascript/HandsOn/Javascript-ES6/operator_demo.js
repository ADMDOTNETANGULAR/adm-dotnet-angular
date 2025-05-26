function f(...a)
{
console.log(a)
}
f(1,2,4,5);
f(12,34,45,78,90)
function sum(a,b)
{
    console.log(a+b);
}
var arr=[12,23];
//sum(...arr);
function learn(mainsub,sub,...othersubs)
{
    console.log("learning "+mainsub);
    console.log(Array.isArray(othersubs));
    console.log(othersubs);
}
learn('.js','.html','.css','jquery','angularjs')