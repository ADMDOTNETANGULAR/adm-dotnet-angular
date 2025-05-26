class student {
    constructor(sid, sname, age, city) {
        this.sid = sid;
        this.sname = sname;
        this.age = age;
        this.city = city;
    }
    show() {
        console.log(`ID:${this.sid} Name:${this.sname} Age:${this.age} City:${this.city}`);
    }
}
//array of students
let students = [
    new student(12, 'Rohan', 12, 'Chennai'),
    new student(12, 'Rohan', 11, 'Chennai'),
    new student(13, 'Rohan', 12, 'Bangalore'),
    new student(14, 'Rohan', 11, 'Chennai'),
    new student(15, 'Rohan', 12, 'Bangloar'),
    new student(16, 'Rohan', 10, 'Delhi'),
]
for (let stu of students) {
    stu.show(); //method defined in student class
}