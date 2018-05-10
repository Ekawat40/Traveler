var express = require('express');
var app = express();

app.get('/',(req,res)=> res.send('Hello world kuy eak'));

app.listen(3000,()=> console.log('Hello kuy eak'));