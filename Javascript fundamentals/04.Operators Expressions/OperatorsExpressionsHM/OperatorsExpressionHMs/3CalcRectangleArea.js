jsConsole.writeLine("Check console for results also F12");

var calcRectangleArea = function () {
    var firstSide = document.getElementById("side1").value;
    var parsedFirstSide = parseFloat(firstSide);
    var secondSide = document.getElementById("side2").value;
    var parsedSecondSide = parseFloat(secondSide);

    if (isNaN(parsedFirstSide) || isNaN(parsedSecondSide)) {
        jsConsole.writeLine("Entered value is NaN try with new one!")
        console.log("Entered value is NaN try with new one!")
    } else {
        var rectangleArea = parsedFirstSide * parsedSecondSide;

        jsConsole.writeLine("Rectangle area : " + rectangleArea);
        console.log("Rectangle area : " + rectangleArea)
    }
};