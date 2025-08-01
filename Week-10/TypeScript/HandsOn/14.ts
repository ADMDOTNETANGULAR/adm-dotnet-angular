//working with arrays using spread operator ...
let arr1=[23,34,45];
let arr2=[98,76,34];
let copyArray=[...arr1]
console.log('Copied Array: '+copyArray)
//create new array with existing array
let newArray=[...arr2,89,90,13]
//merge array
let mergeArray=[...arr1,...arr2]
console.log('Merged Array: '+mergeArray)