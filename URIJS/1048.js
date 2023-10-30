var input = require("fs").readFileSync("stdin", "utf8");

var ENTRADA = input.split(" ");

var A = parseFloat(ENTRADA.shift());
var B = parseFloat(ENTRADA.shift());
var C = parseFloat(ENTRADA.shift());

var PERIMETRO = A + B + C;
var AREA = ((A + B) * C) / 2;

if ((B+C> A) && (A+C>B) && (A+B>C))
{
    console.log("Perimetro = " + PERIMETRO.toFixed(1));
}
else
{
    console.log("Area = " + AREA.toFixed(1));
}