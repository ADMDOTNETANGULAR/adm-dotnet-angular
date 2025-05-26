var sum = (a, b) => a + b;
console.log(sum(100, 2))
var sum1 = (a, b) => {
    a = a + 10;
    b = b + 10;
    return a + b;
};
console.log(sum1(10, 10))
function sum2(p, q) {
    console.log(p() + q());
}
sum2(() => 12 + 3, () => 102);