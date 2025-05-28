// function sum(a) {
//     let sum = 0;
//     for (let k of a) {
//         sum = sum + k;
//     }
//     console.log(sum);
// }
// sum([12,23,34,45])
function add(x,y)
{
    return x + y;
}
function sum(...a) // Using rest operator to accept variable number of arguments
{
    let sum = 0;
    for (let k of a) {
        sum = sum + k;
    }
    console.log(sum);
}
add(10,20);
sum(12,23,34,45,56);
sum(12,23,34,45,56,67,78,89,90);
sum(12,23,34,45,56,67,78,89,90,100,110,120);
sum(12,23,34,45,56,67,78,89,90,100,110,120,130,140,150);