var input = require("fs").readFileSync("stdin", "utf8");

var ENTRADA = input.split(" ");

var A = parseFloat(ENTRADA.shift());
var B = parseFloat(ENTRADA.shift());
var C = parseFloat(ENTRADA.shift());
var PI = 3.14159;

var AREA_TRIANGULO = (A * C) / 2.0;
var AREA_CIRCULO = PI * (C * C);
var AREA_TRAPEZIO = ((A + B) * C)/2.0;
var AREA_QUADRADO = (B * B);
var AREA_RETANGULO = (A * B);

console.log("TRIANGULO: " + AREA_TRIANGULO.toFixed(3));
console.log("CIRCULO: " +  AREA_CIRCULO.toFixed(3));
console.log("TRAPEZIO: " + AREA_TRAPEZIO.toFixed(3));
console.log("QUADRADO: " + AREA_QUADRADO.toFixed(3));
console.log("RETANGULO: " + AREA_RETANGULO.toFixed(3));