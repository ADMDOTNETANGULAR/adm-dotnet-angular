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

function fun()
{
    function fun2()
    {
        let i=100;
    }
    fun2();
    console.log(i);
}
fun();