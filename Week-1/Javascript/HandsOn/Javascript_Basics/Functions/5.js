function callback(yes,no) //here yes and no used as a function
{
    console.log(yes()+' '+no());
}
function yes()
{
    return 'Yes';
}
function no()
{
    return 'No'
}
callback(yes,no)
callback(function(){return 'Ram'},function(){return 'Krishna'})
callback(()=>"Ram",()=>'Rahim')