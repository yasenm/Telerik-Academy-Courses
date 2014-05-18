jsConsole.writeLine("Write a function that returns the last digit of given integer as an English word.");
jsConsole.writeLine("Examples: 512  \"two\", 1024  \"four\", 12309  \"nine\".");
jsConsole.writeLine("Check console for results also F12");

var userValue;

function getValue() {
    var userInput = document.getElementById("userInput").value,
        parsedInput = parseInt(userInput);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("");
        jsConsole.writeLine("Entered value is NaN try with new one!");
        console.log("");
        console.log("Entered value is NaN try with new one!");
    } else {
        userValue = parsedInput;
    }
}


function getLastDigitSpelling(userInt) {
    var digit = userInt % 10,
        result;

    switch (digit) {
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
            jsConsole.writeLine("not found"); break;

    }

    return "Last digit is : " + result;
}

var spellAndPrintLastDigit = function () {
    getValue();
    jsConsole.writeLine(getLastDigitSpelling(userValue));
};
