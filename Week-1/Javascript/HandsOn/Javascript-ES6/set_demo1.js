const numbers=new Set([1,3,4,6,7]);
numbers.add(12)
numbers.add(34)
numbers.add(3);
console.log(numbers.size);
//return all the values from Set
numbers.delete(1); //remove item from Set
for(let k of numbers)
{
    console.log(k);
}

