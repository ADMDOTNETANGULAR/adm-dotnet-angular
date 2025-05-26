(function()
{
    console.log("I am IIFE")
}());
(function(name)
{
    console.log("Hello "+name);
}('Sachin'));
let x=(function(name)
{
    return 'Hello '+name;
}('Sachin'));
console.log(x);