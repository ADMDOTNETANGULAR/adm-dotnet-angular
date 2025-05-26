//print even values in 1 to 100
for(let i=1;i<=100;i++)
{
    if(i%2!=0)
    continue;
    console.log(i);
}
let x=''
for(let i=1;i<=5;i++)
{
    for(let j=1;j<=i;j++)
    {
        x+='* '
    }
    console.log(x);
    x='';
}