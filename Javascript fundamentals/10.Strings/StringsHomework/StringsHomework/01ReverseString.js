jsConsole.writeLine("Write a JavaScript function reverses string and returns it");
jsConsole.writeLine("Example: \"sample\"  \"elpmas\".");
jsConsole.writeLine("Check console for results also F12");

var userValue;

function getValue() {
    userValue = document.getElementById("userInput").value;
}

function reverseStringClick(userInt) {
    getValue();
    jsConsole.writeLine("Reversed is : " + reverseString(userValue));
}

function reverseString(str) {
    var result = '',
        i;
    for (i = str.length - 1; i >= 0 ; i -= 1) {
        result += str[i];
    }

    return result;
}
