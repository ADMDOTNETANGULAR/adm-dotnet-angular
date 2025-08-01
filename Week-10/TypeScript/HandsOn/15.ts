//Tuple Demo
let arrTuple=[100,'TypeScript',12.34,'Abiram']
console.log(arrTuple)
let t1=[100,101]; //tuple with two elements
t1[0]=100;
t1[1]=101;
console.log(t1);
//access element in a tuple
console.log(t1[0]);
console.log(t1[1]);
//add value to tuple using push()
t1.push(123);
console.log(t1);
t1.pop(); //remove last value from tuple
console.log(t1);