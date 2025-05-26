var myFunc=[];
for(let i=0;i<=10;i++)
    {
        myFunc.push(function()
    {
        return i;
    });
    }
    console.log(myFunc[3]());
    console.log(myFunc[6]());