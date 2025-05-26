
let myPromise=new Promise((resolve,resject)=>
{
setTimeout(()=>{resolve('I Love with Promise')},3000);
});
myPromise.then((value)=>console.log(value));