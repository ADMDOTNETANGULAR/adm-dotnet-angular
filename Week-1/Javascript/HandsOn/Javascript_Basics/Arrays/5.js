let numbers = [12, 3, 45, 56, 78];
// numbers.push(96); //item added at last
// console.log(numbers);
// numbers.unshift(10); //item added at begining
// console.log(numbers);
// numbers.pop(); //last item removed
// console.log(numbers);
// numbers.shift(); //item remove from begining
// console.log(numbers);
// splice 
// let arr1 = [23, 45, 67, 78, 89, 90, 12]
// console.log(arr1);
// let a2 = arr1.splice(0, 2); //remove 2 items from 0th index
// console.log(a2); //removed items are returned
// console.log(arr1); //remaining items in arr1
// arr1.splice(0,2,200,100); //removed first 2 items and replaced with 200,100
// console.log(arr1);

// //slice
// let arr1=[23,45,67,78,89,90,12]
// let arr2=arr1.slice(1,4);
// console.log(arr1); //original array remains unchanged
// console.log(arr2);

//concat
let arr1 = [23, 45, 67, 78, 89, 90, 12]
let arr2 = arr1.concat(100, 300)
let arr3=arr1.concat(arr2); //concatenating arr1 with arr2
console.log(arr2);

