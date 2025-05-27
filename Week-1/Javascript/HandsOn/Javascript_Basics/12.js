//javascript loops
// for loop
for (let i = 0; i < 5; i++) {
    console.log(i);
}
// while loop
let j = 0;
while (j < 5) {
    console.log(j);
    j++;
}
// do while loop
let k = 0;
do {
    console.log(k);
    k++;
}while (k < 5);
// for...in loop
let obj = {a: 1, b: 2, c: 3};
for (let key in obj) {
    console.log(key, obj[key]);
}
// for...of loop
let arr = [1, 2, 3, 4, 5];
for (let value of arr) {
    console.log(value);
}   
// forEach loop
arr.forEach(function(value, index) {
    console.log(index, value);
});
// break and continue statements
for (let l = 1; l < 100; l++) {
    if (l%2===1) {
        continue; // skip the rest of the loop when l is 2
    }
    console.log(l);
}   
// break statement
for (let m = 1; m < 100; m++) {
    if (m > 10) {
        break; // exit the loop when m is greater than 10
    }
    console.log(m);
}
// nested loops
for (let n = 0; n < 3; n++) {
    for (let o = 0; o < 3; o++) {
        console.log(`Outer loop: ${n}, Inner loop: ${o}`);
    }
}   
