// function fun()
// {
//     function fun2()
//     {
//         i=100;
//     }
//     fun2();
//     console.log(i);
// }
// fun();

function fun() {
    function fun2() {
        let i = 100;
    }
    fun2();
    console.log(i);// This will throw an error because i is not defined in this scope
}
fun();