class Product {
  constructor() {
    // Initializing properties
    // with default values
    this.Pid = 0;
    this.Pname = "";
    this.Price = 0;
    this.Stock = 0;
  }
}
// Creating an instance of Product
const product = new Product();
// Setting properties
product.Pid = 1;
product.Pname = "Mouse";
product.Price = 400;
product.Stock = 10;
console.log(
  `Product ID: ${product.Pid}, Name: ${product.Pname}, Price: ${product.Price}, Stock: ${product.Stock}`
);  