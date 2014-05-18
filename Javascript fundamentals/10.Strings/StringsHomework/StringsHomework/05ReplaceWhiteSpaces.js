jsConsole.writeLine("Write a function that replaces non breaking white-spaces in a text with &nbsp;");
jsConsole.writeLine("Check console for results also F12");

var text = "We are       living  in a  yellow submarine. We  don't                 have  anything  else.",
    pattern;

jsConsole.writeLine(text);
console.log(text);

function removeWhiteSpaces(str) {
    var i,
        lastWhiteSpace = false,
        result = '';

    for (i = 0; i < str.length; i += 1) {
        if (str[i] === ' ') {
            if (lastWhiteSpace) {
                continue;
            }

            lastWhiteSpace = true;
            result += str[i];
        } else {
            lastWhiteSpace = false;
            result += str[i];
        }
    }

    return result;
}

jsConsole.writeLine(removeWhiteSpaces(text));
console.log(removeWhiteSpaces(text));