jsConsole.writeLine("Write a program that finds the biggest of three integers using nested if statements.");
jsConsole.writeLine("Check console for results also F12");

var biggestOutOfThreeInts = function () {
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
        if (parsedFirstInt > parsedSecondInt && parsedFirstInt > parsedThirdInt) {
            jsConsole.writeLine("Number -> " + parsedFirstInt);
        } else if (parsedFirstInt === parsedSecondInt && parsedFirstInt === parsedThirdInt) {
            jsConsole.writeLine("Numbers are equal");
        } else {
            if (parsedSecondInt > parsedFirstInt && parsedSecondInt > parsedThirdInt) {
                jsConsole.writeLine("Number -> " + parsedSecondInt);
            } else if (parsedThirdInt > parsedFirstInt && parsedSecondInt < parsedThirdInt) {
                jsConsole.writeLine("Number -> " + parsedThirdInt);
            }
        }
    }
};