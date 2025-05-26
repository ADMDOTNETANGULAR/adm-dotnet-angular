//Javascript Set Objects
//A set is a collection of unique values.
//A set can hold value of any type

//Create set
const letters=new Set();
//add values to the Set
letters.add('a');
letters.add('b');
letters.add('c');
letters.add('a');
console.log('Length: '+letters.size);
let isExist=letters.has('a');
console.log(isExist);
//letters.clear(); //clare all objects