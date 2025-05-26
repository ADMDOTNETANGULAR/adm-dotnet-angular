function f(...a) // Rest operator
{
    console.log(a)
}
f(1, 2, 4, 5);
f(12, 34, 45, 78, 90)
function sum(a, b) {
    console.log(a + b);
}
const [a, b] = [12, 23]; // Destructuring assignment
sum(a, b); // Spread operator
function learn(mainsub, sub, ...othersubs) // Rest operator
{
    console.log("learning " + mainsub);
    console.log(Array.isArray(othersubs));
    console.log(othersubs);
}
learn('.js', '.html', '.css', 'jquery', 'angularjs')