//High order functions
// Callback function, passed as a parameter in the higher order function
function callbackFunction() {
  console.log("I am  a callback function");
}
// higher order function
function higherOrderFunction(func) {
  console.log("I am higher order function");
  func();
}
higherOrderFunction(callbackFunction);
