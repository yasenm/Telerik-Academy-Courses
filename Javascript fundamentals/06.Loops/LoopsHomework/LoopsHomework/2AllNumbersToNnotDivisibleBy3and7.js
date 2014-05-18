jsConsole.writeLine("Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.");
jsConsole.writeLine("Check console for results also F12");

var allNumbersToNnotDivisibleBy3and7 = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseInt(userInput);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("Entered value is NaN try with new one!");
        console.log("Entered value is NaN try with new one!");
    } else {
        for (var i = 1; i <= parsedInput; i++) {
            if (i % 3 === 0 && i % 7 === 0) {
                continue;
            }
            jsConsole.writeLine(i);
            console.log(i);
        }
        jsConsole.writeLine("end");
        console.log("end");
    }
};