function sum(p,q)
{
    console.log(p()+q());
}
sum(()=>12+3,()=>102);