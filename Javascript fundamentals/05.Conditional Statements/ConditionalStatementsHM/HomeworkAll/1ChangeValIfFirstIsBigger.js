jsConsole.writeLine("Write an if statement that examines two integer variables" +
    " and exchanges their values if the first one is greater than the second one.");
jsConsole.writeLine("Check console for results also F12");

var changeValIfFirstIsBigger = function () {
    var firstInt = document.getElementById("firstInt").value;
    var parsedFirstInt = parseFloat(firstInt);
    var secondInt = document.getElementById("secondInt").value;
    var parsedSecondInt = parseFloat(secondInt);

    if (isNaN(parsedSecondInt) || isNaN(parsedFirstInt)) {
        jsConsole.writeLine("Entered values are NaN try with new ones!")
        console.log("Entered values are NaN try with new ones!")
    } else {
        if (parsedFirstInt > parsedSecondInt) {
            jsConsole.writeLine("Old value of first int : " + parsedFirstInt);
            jsConsole.writeLine("Old value of second int : " + parsedSecondInt);
            jsConsole.writeLine("");
            console.log("Old value of first int : " + parsedFirstInt);
            console.log("Old value of second int : " + parsedSecondInt);
            console.log("");

            var temp;
            temp = parsedFirstInt;
            parsedFirstInt = parsedSecondInt;
            parsedSecondInt = temp;

            jsConsole.writeLine("New value of first int : " + parsedFirstInt);
            jsConsole.writeLine("New value of second int : " + parsedSecondInt);
            jsConsole.writeLine("");
            console.log("New value of first int : " + parsedFirstInt);
            console.log("New value of second int : " + parsedSecondInt);
            console.log("");
        } else {
            jsConsole.writeLine("No change in values first is lesser than second int");
            console.log("No change in values first is lesser than second int");
        }
    }
};