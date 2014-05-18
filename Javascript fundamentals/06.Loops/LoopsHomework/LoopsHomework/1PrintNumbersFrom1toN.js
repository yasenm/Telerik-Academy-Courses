jsConsole.writeLine("Write a script that prints all the numbers from 1 to N");
jsConsole.writeLine("Check console for results also F12");

var printNumbersFrom1toN = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseInt(userInput);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("Entered value is NaN try with new one!");
        console.log("Entered value is NaN try with new one!");
    } else {
        for (var i = 1; i <= parsedInput; i++) {
            jsConsole.writeLine(i);
            console.log(i);
        }
        jsConsole.writeLine("end");
        console.log("end");
    }
};