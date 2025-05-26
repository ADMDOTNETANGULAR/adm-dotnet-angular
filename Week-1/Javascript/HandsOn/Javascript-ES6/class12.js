class Student
{
    constructor(sid,sname,age)
    {
        this.Sid=sid;
        this.Sname=sname;
        this.Age=age;
    }
    show()
    {
        console.log("ID: "+this.Sid);
        console.log("Name: "+this.Sname);
        console.log("Age: "+this.Age);
    }
}
var obj=new Student(100,'Karan',10);
console.log(obj.Sname)
obj.show();