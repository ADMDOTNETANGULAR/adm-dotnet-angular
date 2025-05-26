let users=[
    {id:1,name:'Tim',salary:1200},
    {id:2,name:'John',salary:15000},
    {id:3,name:'Suren',salary:20000},
    {id:4,name:'Tony',salary:13000},
]
//Find

// let user=users.find(i=>i.id>2)
// if(user!=null)
// console.log(user.name);
// else
// console.log('Invalid Id')

//Filter
//return multiple values
let arr=users.filter(i=>i.salary>13000)
console.log(arr);
