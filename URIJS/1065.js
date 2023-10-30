var input = require("fs").readFileSync("stdin", "utf8");

var ENTRADA = input.split('\n');
var CONTADOR = 0;

for (let i = 0; i < 5; i++)
{
    if (ENTRADA[i]%2 === 0) CONTADOR++;
}

console.log(CONTADOR + " valores pares")