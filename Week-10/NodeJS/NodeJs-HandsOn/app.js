//declare the http module
const http = require('http');//declare the express module
//create http server
const server = http.createServer((req, res) => {
    //set the response HTTP header with HTTP status and Content type
    res.writeHead(200, { 'Content-Type': 'text/plain' });
    //send the response body "Hello World"
    res.end('Hello World\n');
});
//listen on port 3000
server.listen(4002, () => {
    console.log('Server is running at http://localhost:4002/');
});