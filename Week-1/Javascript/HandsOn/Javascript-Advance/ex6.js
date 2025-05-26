let myVar=setInterval(myTimer,1000);
function myTimer()
{
    var d=new Date();
    var op=d.toLocaleTimeString();
    console.log(op);
}
function myStopFunction()
{
    clearInterval(myVar)
}
myStopFunction();