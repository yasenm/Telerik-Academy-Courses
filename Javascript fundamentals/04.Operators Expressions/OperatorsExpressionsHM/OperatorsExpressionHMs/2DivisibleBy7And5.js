jsConsole.writeLine("Check console for results also F12");

var divisibleBy7And5 = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseFloat(userInput);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("Entered value is NaN try with new one!")
        console.log("Entered value is NaN try with new one!")
    } else {
        if (parsedInput % 5 === 0) {
            if (parsedInput % 7 === 0) {
                jsConsole.writeLine("Divisible!")
                console.log("Divisible!")
            } else {
                jsConsole.writeLine("Not divisible!")
                console.log("Not divisible!")
            }
        } else {
            jsConsole.writeLine("Not divisible!")
            console.log("Not divisible!")
        }
    }
};