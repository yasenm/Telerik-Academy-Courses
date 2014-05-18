jsConsole.writeLine("Write a JavaScript function to check if in a given expression the brackets are put correctly.");
jsConsole.writeLine("Example of correct expression: ((a+b)/5-d).");
jsConsole.writeLine("Example of incorrect expression: )(a+b)).");
jsConsole.writeLine("Check console for results also F12");

var userValue;

function getValue() {
    userValue = document.getElementById("userInput").value;
}

function checkBrackecsClickEv(userInt) {
    getValue();
    jsConsole.writeLine("Brackets entry is : " + checkBrackecs(userValue));
}

function checkBrackecs(str) {
    var result = false,
        i,
        brackets = [];
    for (i = 0; i < str.length; i++) {
        if (str[i] === '(') {
            brackets.push("");
        }
        if (str[i] === ')') {
            brackets.pop("");
        }
    }

    if (brackets.length === 0) {
        result = true;
    }

    return result;
}
