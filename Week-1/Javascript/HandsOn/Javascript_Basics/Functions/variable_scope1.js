let global='This is global variable';
// function fun()
// {
//     let global='This is local varialbe';
// }
// fun();
// console.log(global);

function fun()
{
    // This is a local variable
    let global='This is local varialbe';
    console.log(global); // This will log the local variable
    console.log(window.global); //access global variables
}
fun();

