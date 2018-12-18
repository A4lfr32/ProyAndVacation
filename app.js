const express = require('express'); //importando express, libreria
const app = express(); //creando app
app.use(express.json()); //vamos usar json en formato json
app.use(express.static('Public')); //nuestra carpeta publica es public
var usuarioLogeado = false;

const mysql = require('mysql');

const connection = mysql.createConnection({
    host : "localhost",
    user : 'root',
    password : 'claveroot',
    database : 'usuarios'

});

app.get("", function(req,res) {
    res.sendfile(__dirname + "\\Public\\login.html");
});


app.listen(3000, function () {
    console.log("escuchando puerto 3000...");
});
