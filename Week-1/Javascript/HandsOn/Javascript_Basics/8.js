//if-else-if
let m1=9,m2=7,m3=6;
let total=(m1+m2+m3);
let avg=total/3;
if(avg>=70)
console.log('Distinction');
else if(avg>=60 && avg<70)
console.log('FirstClass');
else if(avg>=50 && avg<60)
console.log('SecondClass');
else if(avg>=35 && avg<50)
console.log('ThirdClass');
else
console.log("Fail");