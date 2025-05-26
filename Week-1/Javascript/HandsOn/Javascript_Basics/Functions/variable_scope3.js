function fun() {
    if (true) {
        let i = 100;
    }
    console.log(i);// This will throw an error because i is not defined in this scope
}
fun();