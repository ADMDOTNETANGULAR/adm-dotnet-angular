class Program
{
    constructor(private msg:string)
    {

    }
    show()
    {
        console.log("Your Message: "+this.msg);
    }
}
let obj=new Program("Hello TypeScript");
obj.show()