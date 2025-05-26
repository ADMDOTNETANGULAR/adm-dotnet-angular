class Person {
  constructor() {
    //default constructor
    this.Pid = 1;
    this.Pname = "Ram";
    this.City = "Bangalore";
  }
}
const person = new Person();
console.log(person.Pid + " " + person.Pname + " " + person.City);
const person1 = new Person();
person1.Pid = 2;
person1.Pname = "Virat";
person1.City = "Delhi";
console.log(person1.Pid + " " + person1.Pname + " " + person1.City);
