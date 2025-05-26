function f()
{
    let d=new Date();
    console.log(d.getHours()+":"+d.getMinutes()+":"+d.getSeconds());
}
setInterval(f,1000);
clearInterval()