var input = require("fs").readFileSync("stdin", "utf8");

var ENTRADA = input.split("\n");

var A = parseInt(ENTRADA.shift());
var B = parseInt(ENTRADA.shift());
var C = parseInt(ENTRADA.shift());
var D = parseInt(ENTRADA.shift());

var DIF = A * B - C * D;

console.log("DIFERENCA = " + DIF);