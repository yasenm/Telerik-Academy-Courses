jsConsole.writeLine("Check console for results also F12");

var checkOddOrEven = function () {
    var userInput = document.getElementById("userInput").value;

    if (isNaN(parseInt(userInput))) {
        jsConsole.writeLine("Entered value is NaN try with new one!")
        console.log("Entered value is NaN try with new one!")
    } else {
        if (parseInt(userInput) % 2 === 0) {
            jsConsole.writeLine("Even!")
            console.log("Even!")
        } else {
            jsConsole.writeLine("Odd!")
            console.log("Odd!")
        }
    }
};