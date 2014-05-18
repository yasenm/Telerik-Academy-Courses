jsConsole.writeLine("Write a program that enters the coefficients a, b and c of a quadratic equation");
jsConsole.writeLine("a*x2 + b*x + c = 0");
jsConsole.writeLine("and calculates and prints its real roots. Note that quadratic equations");
jsConsole.writeLine("may have 0, 1 or 2 real roots.");
jsConsole.writeLine("Check console for results also F12");

var quadraticEquation = function () {
    var a = document.getElementById("firstInt").value;
    var parsedA = parseFloat(a);
    var b = document.getElementById("secondInt").value;
    var parsedB = parseFloat(b);
    var c = document.getElementById("thirdInt").value;
    var parsedC = parseFloat(c);
    var discriminant;

    if (isNaN(parsedA) || isNaN(parsedB) || isNaN(parsedC)) {
        jsConsole.writeLine("Entered values are NaN try with new ones!");
        console.log("Entered values are NaN try with new ones!");
    } else {
        discriminant = Math.pow(b, 2) - (4 * a * c);

        if (discriminant < 0) {
            jsConsole.writeLine("No real roots!");
            console.log("No real roots!");
        } else if (discriminant === 0) {
            var root = -b / (2 * a);
            jsConsole.writeLine("One root x1,2 : " + root + ";");
            console.log("One root : " + root + ";");
        } else {
            var root1 = (-b + Math.sqrt(discriminant)) / (2 * a);
            var root2 = (-b - Math.sqrt(discriminant)) / (2 * a);

            jsConsole.writeLine("Root one x1 : " + root1 + ";");
            jsConsole.writeLine("Root two x2 : " + root2 + ";");
            console.log("Root one x1 : '" + root1 + "';");
            console.log("Root two x2 : '" + root2 + "';");
        }
    }
};