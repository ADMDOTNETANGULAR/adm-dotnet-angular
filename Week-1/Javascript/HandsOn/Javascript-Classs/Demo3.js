// Parent class
class Animal {
  constructor(name) {
    this.name = name;
  }

  speak() {
    console.log(`${this.name} makes a noise.`);
  }
}

// Child class inherits from Animal
class Dog extends Animal {
  constructor(name, breed) {
    super(name); // call the parent constructor
    this.breed = breed;
  }

  speak() {
    console.log(`${this.name} barks.`);
  }
}

const dog = new Dog('Rex', 'Labrador');
dog.speak(); // Rex barks.
