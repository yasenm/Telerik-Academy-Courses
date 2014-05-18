jsConsole.writeLine("Check console for results also F12");

var thirdDigitIs7 = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseFloat(userInput);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("Entered value is NaN try with new one!")
        console.log("Entered value is NaN try with new one!")
    } else {
        var result = parseInt(parsedInput / 100) % 10;

        if (result === 7) {
            jsConsole.writeLine("Is 7!")
            console.log("Is 7!")
        } else {
            jsConsole.writeLine("Not 7!")
            console.log("Not 7!")
        }
    }
};