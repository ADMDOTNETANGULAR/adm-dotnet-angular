let global='This is global variable';
// function fun()
// {
//     let global='This is local varialbe';
// }
// fun();
// console.log(global);

function fun()
{
    global='This is local varialbe';
    console.log(global);
}
fun();
//console.log(global);

// function fun()
// {
//     let global='This is local varialbe';
//     console.log(global);
//     console.log(window.global); //access global variables
// }
// fun();
