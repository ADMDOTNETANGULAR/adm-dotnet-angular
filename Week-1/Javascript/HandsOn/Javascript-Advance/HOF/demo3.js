//with HOF
const radius = [1, 2, 3];
// logic to clculate area
const area = function (radius) {
  return Math.PI * radius * radius;
};
// logic to calculate diameter
const diameter = function (radius) {
  return 2 * radius;
};
const circumeference = function (radius) {
  return 2 * Math.PI * radius;
};
// a reusable function to calculate area, diameter, etc
const calculate = function (radius, logic) {
  const output = [];
  for (let i = 0; i < radius.length; i++) {
    output.push(logic(radius[i]));
  }
  return output;
};
console.log(calculate(radius, area));
console.log(calculate(radius, diameter));
console.log(calculate(radius, circumeference));
