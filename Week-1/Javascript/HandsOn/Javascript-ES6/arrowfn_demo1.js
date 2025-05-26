var age = 12;

function Person(){
  this.age = 34;

  setTimeout(() => {
    console.log(this.age); //34 //return local variable value
  }, 1000);

  setTimeout(function(){
    console.log(age); //12 //return global variable value
  }, 1000);  
}

var p = new Person();