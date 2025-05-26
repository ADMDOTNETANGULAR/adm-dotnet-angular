class Product {
    constructor() {
        this.pid = 0;
        this.pname = '';

    }
    set PID(value) {
        this.pid = value;
    }
    get PID() {
        return this.pid;
    }
    set Pname(value) {
        this.pname = value;
    }
    get Pname() {
        return this.pname;
    }
}
let product = new Product();
product.PID = 100
product.Pname = 'Mouse'
console.log(`PID:${product.PID} Pname:${product.Pname}`)