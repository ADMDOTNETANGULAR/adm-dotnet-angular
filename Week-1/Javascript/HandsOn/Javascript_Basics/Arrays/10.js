//map
//it calls the function for each element in the array and returns the array of results.
let flowers=["Rose","Lilly","Tulips"];
let result=flowers.map(item=>item.length);
console.log(result);
result=flowers.map(item=>item.toUpperCase());
console.log(result);
result=flowers.map(item=>item.length>5);
console.log(result);