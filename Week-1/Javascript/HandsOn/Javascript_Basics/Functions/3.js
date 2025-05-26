function GetFlowers()
{
    return [
        'Rose',
        "Lilly",
        "Tulips",
        'Jasmine'
    ];
}
for(let flower of GetFlowers())
{
    console.log(flower)
}
function GetStudents()
{
    let students=[
        {Sid:1,Sname:'Rohan',age:10},
        {Sid:2,Sname:'Ram',age:11},
        {Sid:3,Sname:'Karan',age:10},
        {Sid:4,Sname:'John',age:11},
        {Sid:5,Sname:'Jeson',age:10},
        {Sid:6,Sname:'Tina',age:12},
        {Sid:7,Sname:'Meena',age:11},
        {Sid:8,Sname:'Monica',age:10},
    ]
    return students;
}
for(let student of GetStudents())
{
    console.log(`ID:${student.Sid} Name:${student.Sname} Age:${student.age}`)
}