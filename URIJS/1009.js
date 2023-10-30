var input = require("fs").readFileSync("stdin", "utf8");

var ENTRADA = input.split("\n");

var NOME = ENTRADA.shift();
var SALARIO_FIXO = parseFloat(ENTRADA.shift());
var VENDAS = parseFloat(ENTRADA.shift());

var TOTAL = SALARIO_FIXO + (VENDAS*0.15);

console.log("TOTAL = R$ " + TOTAL.toFixed(2));