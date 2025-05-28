class student {
  //consturctor with parameters
  constructor(name, age) {
    this.name = name;
    this.age = age;
  }
  //define method 
  //to display the values
  //of the properties
  display() {
    console.log(this.name);
    console.log(this.age);

  }
}
var obj = new student("sachin", 12);
obj.display();
var obj1 = new student("Ram", 23);
obj1.display();
var obj2 = new student("Virat", 12);
obj2.display();
