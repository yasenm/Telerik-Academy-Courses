jsConsole.writeLine("Write program that asks for a digit and depending on the " +
    "input shows the name of that digit (in English) using a switch statement.");
jsConsole.writeLine("Check console for results also F12");

var showDigitAsWord = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseFloat(userInput);
    var result;

    if (isNaN(parsedInput) || userInput.length > 1) {
        jsConsole.writeLine("Entered value is NaN or not a single digit try with new entrie!")
        console.log("Entered value is NaN or not a single digit try with new entrie!")
    } else {

        switch (parsedInput) {
            case 0: result = "zero"; break;
            case 1: result = "one"; break;
            case 2: result = "two"; break;
            case 3: result = "three"; break;
            case 4: result = "four"; break;
            case 5: result = "five"; break;
            case 6: result = "six"; break;
            case 7: result = "seven"; break;
            case 8: result = "eight"; break;
            case 9: result = "nine"; break;
            default:
                jsConsole.writeLine("Invalid input"); break;
        }

        jsConsole.writeLine("Word is : '" + result + "';");
        console.log("Word is : '" + result + "';");
    }
};