//callback functions are functions that are passed as arguments to other functions.
// They are often used to handle asynchronous operations or to customize the behavior of a function.
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
callback(yes,no) // Passing functions as arguments
// You can also use arrow functions as callbacks
callback(function(){return 'Ram'},function(){return 'Krishna'})// Passing anonymous functions as arguments
// You can also use arrow functions as callbacks
callback(()=>"Ram",()=>'Rahim')// Passing arrow functions as arguments
// You can also use inline functions as callbacks  
callback(() => 'Inline Yes', () => 'Inline No'); // Passing inline arrow functions as arguments     