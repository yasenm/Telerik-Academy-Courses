jsConsole.writeLine("Write a program that shows the sign (+ or -) of the product of three " +
    "real numbers without calculating it. Use a sequence of if statements.");
jsConsole.writeLine("Check console for results also F12");

var showProductSign = function () {
    var firstInt = document.getElementById("firstInt").value;
    var parsedFirstInt = parseFloat(firstInt);
    var secondInt = document.getElementById("secondInt").value;
    var parsedSecondInt = parseFloat(secondInt);
    var thirdInt = document.getElementById("thirdInt").value;
    var parsedThirdInt = parseFloat(thirdInt);

    if (isNaN(parsedSecondInt) || isNaN(parsedFirstInt) || isNaN(parsedThirdInt)) {
        jsConsole.writeLine("Entered values are NaN try with new ones!")
        console.log("Entered values are NaN try with new ones!")
    } else {
        if ((parsedFirstInt < 0 && parsedSecondInt > 0 && parsedThirdInt > 0) ||
            (parsedFirstInt > 0 && parsedSecondInt < 0 && parsedThirdInt > 0) ||
            (parsedFirstInt > 0 && parsedSecondInt > 0 && parsedThirdInt < 0) ||
            (parsedFirstInt < 0 && parsedSecondInt < 0 && parsedThirdInt < 0)) {
            jsConsole.writeLine("Sign is '-'");
        } else {
            jsConsole.writeLine("Sign is '+'");
        }
    }
};