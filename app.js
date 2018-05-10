var express = require('express');
var app = express();

app.get('/Helloworld',(req,res)=> res.send('Hello World'));

app.listen(3000,()=> console.log('Hello World'));