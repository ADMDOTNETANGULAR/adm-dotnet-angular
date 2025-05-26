let a=10;
a=20;
const x = 12;
//x=20; error
//an constant 'x' is already available in this scope therefore the below line throws an error when you are try to create a new x variable.
//const x = 13; error

if(true)
{
    //an constant 'x' is available in this scope but not defined in this scope therefore the below line will not throw error instead define a new "x" inside this scope.
    const x = 13;
    
    //here 'y' is available inside this scope not outside this scope
    const y = 11;
    console.log(y)
}

//here creating a new 'y' will not throw an error because no other 'y' is available in this scope(i.e., global scope)
//console.log(y) //reference error
const y = 12;
console.log(y)