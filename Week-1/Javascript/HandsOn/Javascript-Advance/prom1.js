var promise=new Promise(function(resolve,reject)
{
const x='Hello';
const y="Hello";
if(x==y){
    resolve();
}
else{
    reject();
}
});
promise.then(
    function(){
        console.log("Success,yor are the Robot");
    },function(){
        console.log("Sorry,you the human");
    }
)