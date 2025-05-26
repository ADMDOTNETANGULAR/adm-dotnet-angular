function OrderFood()
{
    let myorder='Pizza and Pasta';
    function TakeMyOrder()
    {
        return myorder;
    }
    return TakeMyOrder;
}
let order=OrderFood();
console.log('I Love '+order());