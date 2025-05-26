// This is an example of variable scope in JavaScript
// Global and local variables
let global='This is global variable';
function fun()
{
     // This is a local variable
    let local='This is local variable'
    loc='This is a local variable without let or var';
    console.log(global);
    console.log(local);
     console.log(loc);
}
fun()
console.log(global); // This will print the global variable
//console.log(local); // This will throw an error because 'local' is not defined in the global scope
console.log(loc); // The variable 'loc' is not declared with let or var, so it becomes a global variable