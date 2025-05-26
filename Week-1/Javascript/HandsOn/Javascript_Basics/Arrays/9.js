function compareNumeric(a,b)
{
    if(a>b) return 1;
    if(a==b) return 0;
    if(a<b) return -1;
}
console.log([1,2,3,4,11,5].sort(compareNumeric));