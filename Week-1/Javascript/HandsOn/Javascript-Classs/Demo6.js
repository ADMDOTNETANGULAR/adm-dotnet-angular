class Foo {
  static M() {
    return "Hello";
  }
}
console.log(Foo.M());
class Bar extends Foo {}
console.log(Bar.M());
class Jar extends Foo {
  static M() {
    return super.M() + " too";
  }
}
console.log(Jar.M());
