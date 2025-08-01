function PrintNumbers(nos:number[])
{
    for(let k of nos)
    {
        console.log(k);
    }
}
PrintNumbers([12,34,45,67,78]);
function GetFlowers()
{
    return ['Lilly','Rose','Marigold','Tulips']
}
for(let n of GetFlowers())
{
    console.log(n)
}