// yield* it iterates over the operand and returns each value until done it true.
const arr=['a','b','c']
function* generator()
{
    yield 1;
    yield* arr;
    yield 2;
}
for(let v of generator())
{
    console.log(v);
}