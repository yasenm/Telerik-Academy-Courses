jsConsole.writeLine("Write a function that reverses the digits of given decimal number. Example: 256  652");
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

function reverseNumber(userInt) {
    var number = userInt.toString(),
        result = "";

    for (var i = number.length - 1; i >= 0; i--) {
        result = result + number.substr(i, 1);
    }
    return "Reverse number is : " + result;
}

function reverseNumberClick() {
    getValue();
    jsConsole.writeLine(reverseNumber(userValue));
};
