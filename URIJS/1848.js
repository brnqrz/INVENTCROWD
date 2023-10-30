var input = require("fs").readFileSync("stdin", "utf8");
var ENTRADA = input.split('\n');

var GRITO;
var LOTERIA;

for (var i = 0; i<3; i++)
{
    LOTERIA = 0;
    while (true)
    {
        GRITO = ENTRADA.shift();
        if (GRITO[0] == '*') LOTERIA += 4;
        if (GRITO[1] == '*') LOTERIA += 2;
        if (GRITO[2] == '*') LOTERIA += 1;
        
        if (GRITO[0] >= 'c') break;
    }

     console.log(LOTERIA);
}