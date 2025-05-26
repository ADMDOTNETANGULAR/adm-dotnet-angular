function f()
{
    console.log("Hello Callback..");
}
//setTimeout(f,3000)
setTimeout(()=>{
    console.log("Hello Callback");
},3000);