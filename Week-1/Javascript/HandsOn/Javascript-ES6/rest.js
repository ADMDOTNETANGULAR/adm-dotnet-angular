// function sum(a) {
//     let sum = 0;
//     for (let k of a) {
//         sum = sum + k;
//     }
//     console.log(sum);
// }
// sum([12,23,34,45])

function sum(...a) // Using rest operator to accept variable number of arguments
{
    let sum = 0;
    for (let k of a) {
        sum = sum + k;
    }
    console.log(sum);
}
sum(12,23,34,45,56);