export class Product {
    // Represents a product with an ID, name, price, and description
    // The constructor initializes these properties
    constructor(
        public id: number,
        public name: string,
        public price: number,
        public description: string
    ) {}
}
