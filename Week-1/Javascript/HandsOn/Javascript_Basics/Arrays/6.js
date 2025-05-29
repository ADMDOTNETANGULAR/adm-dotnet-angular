let arr1=[23,45,67,78,89,90,12,78]
arr1.forEach(i=>console.log(i))
arr1.forEach(i=>console.log(i*i));
arr1.forEach((item,index)=>{
    console.log(`${item} is at index ${index}`)
})
// arr1.forEach((item,index,array)=>{
//     console.log(`${item} is at index ${index} in ${array}`)
// })
console.log(arr1.indexOf(78))
console.log(arr1.lastIndexOf(78))

