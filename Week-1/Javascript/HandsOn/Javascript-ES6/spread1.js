let arr1=[12,23,45];
let arr2=[34,45];
let arr3=arr1.concat(...arr2); // Using concat method to merge arrays
let arr34=[...arr1,...arr2] // Using spread operator to merge arrays
for(let k of arr3)
console.log(k);