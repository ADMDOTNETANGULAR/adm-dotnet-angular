function Dispaly(n)
{
    console.log(n);
}
function Calculate(n1,n2,callback)
{
    let sum=n1+n2;
    callback(sum);
}
Calculate(4,5,Dispaly);