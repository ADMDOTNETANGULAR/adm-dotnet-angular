let arr1=[12,23,45];
let arr2=[34,45];
//let arr3=arr1.concat(...arr2);
let arr3=[...arr1,...arr2]
for(let k of arr3)
console.log(k);