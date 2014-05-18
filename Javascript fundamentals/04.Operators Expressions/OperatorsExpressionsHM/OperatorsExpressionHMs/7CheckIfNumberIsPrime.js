jsConsole.writeLine("Check console for results also F12");

var checkIfNumberIsPrime = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseInt(userInput);
    var prime = true;

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("Entered value is NaN try with new one!")
        console.log("Entered value is NaN try with new one!")
    } else {
        var i = 1;

        while (i < parsedInput) {
            if (parsedInput % 2 === 0) {
                prime = false;
                break;
            }

            i++;
        }

        jsConsole.writeLine(prime ? "Number is prime!" : "Not prime number!");
    }
};