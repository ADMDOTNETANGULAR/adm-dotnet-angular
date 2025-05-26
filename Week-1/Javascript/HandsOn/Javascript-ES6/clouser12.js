function foo(outer_arg)
{
    function inner(inner_org)
    {
        return outer_arg+inner_org;
    }
    return inner;
}
var get_inner_func=foo(10);
console.log(get_inner_func(5));
console.log(get_inner_func(2));