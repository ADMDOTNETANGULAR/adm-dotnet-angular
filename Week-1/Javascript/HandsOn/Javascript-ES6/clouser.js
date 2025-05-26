function outer()
{
    function inner()
    {
        console.log('I am a Clouser');
    }
    return inner;
}
let f=outer();
f();