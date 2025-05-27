// Arrays can hold different types of data including numbers, strings, objects, and functions.
let items = [
    12,
    23.34,
    true,
    'Ram',
    { Sid: 1, Sname: 'Cherri' },
    () => 5
];
// console.log(items[0]);
// console.log(items[2]);
// console.log(items[5]()); // Accessing function 
// console.log(`ID:${items[4].Sid} Name:${items[4].Sname}`) // Accessing object properties
// console.log(items[3].toUpperCase()); // Accessing string method
for (let i = 0; i < items.length; i++) {
    if (typeof items[i] === 'function') {
        console.log(items[i]()); // Call the function if it's a function
    }
    else if (typeof items[i] === 'object') {
        console.log(`ID: ${items[i].Sid}, Name: ${items[i].Sname}`); // Accessing object properties
    } else if (typeof items[i] === 'string') {
        console.log(items[i].toUpperCase()); // Accessing string method
    } else {
        console.log(items[i]); // For other types like number and boolean
    }

}