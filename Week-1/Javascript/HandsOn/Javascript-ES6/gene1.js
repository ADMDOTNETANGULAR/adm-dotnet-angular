//Generator Demo
//Yield: pauses the generator execution and it returns the value of the expression which is being written
//after the yield keyword.
let arr=['a','b','c']
function* generator(arr)
{
    let i=0;
    while(i<arr.length)
    {
        yield arr[i++]
    }

}
const v=generator(arr);
console.log(v.next());