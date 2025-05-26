//types of data
// 1. Primitive Data Types
let name = "John"; // string
name='Doe'; // reassigning string
let age = 30; // number 
let stockPrice = 150.75; // number with decimal
let isStudent = false; // boolean
// 2. Non-Primitive Data Types
let hobbies = ["reading", "gaming", "coding"]; // array
let person = { // object
  firstName: "Jane",
  lastName: "Doe",
  age: 25
};
// 3. Function  
function greet() { // function
  console.log("Hello, World!");
}
// 4. Null and Undefined
let emptyValue = null; // null
let notAssigned; // undefined
console.log(notAssigned); // undefined
console.log(emptyValue); // null
console.log(`Name: ${person.lastName}, FirstName: ${person.firstName}, Age: ${person.age}`); // Template literals