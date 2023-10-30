var input = require("fs").readFileSync("stdin", "utf8");
var ENTRADA = input.split(" ");

var A = parseFloat(ENTRADA.shift());
var B = parseFloat(ENTRADA.shift());
var C = parseFloat(ENTRADA.shift());

var DELTA = Math.pow(B,2) - 4 * A * C;
var R1 = (-B + Math.sqrt(DELTA)) / (2 * A);
var R2 = (-B - Math.sqrt(DELTA)) / (2 * A);

if (DELTA < 0 || A == 0)
{
    console.log("Impossivel calcular")
}
else
{
    console.log("R1 = " + R1.toFixed(5));
    console.log("R2 = " + R2.toFixed(5)); 
}