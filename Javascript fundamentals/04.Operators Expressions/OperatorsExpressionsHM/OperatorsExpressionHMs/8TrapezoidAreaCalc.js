jsConsole.writeLine("Trapezoid area calculator");
jsConsole.writeLine("Check console for results also F12");

var trapezoidAreaCalc = function () {
    var sideA = document.getElementById("sideA").value;
    var parsedSideA = parseFloat(sideA);
    var sideB = document.getElementById("sideB").value;
    var parsedSideB = parseFloat(sideB);
    var hightH = document.getElementById("hightH").value;
    var parsedHightH = parseFloat(hightH);

    if (isNaN(parsedSideA) || isNaN(parsedSideB) || isNaN(parsedHightH)) {
        jsConsole.writeLine("Entered values is NaN try with new one!")
        console.log("Entered values is NaN try with new one!")
    } else {
        var trapezoidArea = ((parsedSideA + parsedSideB) / 2) * parsedHightH;

        jsConsole.writeLine("Trapezoid's area is : " + trapezoidArea + " ;");
        console.log("Trapezoid's area is : " + trapezoidArea + " ;");
    }
};