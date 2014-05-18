jsConsole.writeLine("Write a function that finds all the occurrences of word in a text");
jsConsole.writeLine("- The search can case sensitive or case insensitive");
jsConsole.writeLine("- Use function overloading");
jsConsole.writeLine("Check console for results also F12");

var userValue;
var text = document.getElementById("textContainer").innerHTML;
var textArr = text.split(/(?:,| |<br>|\?|\(|\)|<br|\/>)+/);

function getValue() {
    userValue = document.getElementById("userInput").value;
}

function findWordOccurancesCaseInsensitive() {
    getValue();
    var resultCounter = 0;

    for (var i = 0; i < textArr.length; i++) {
        if (userValue.toLowerCase() === textArr[i].toLowerCase()) {
            resultCounter++;
        }
    }

    jsConsole.writeLine("Case insensitive result : " + resultCounter);
    console.log("Case insensitive result : " + resultCounter);
}

function findWordOccurancesCaseSensitive() {
    getValue();
    var resultCounter = 0;

    for (var i = 0; i < textArr.length; i++) {
        if (userValue === textArr[i]) {
            resultCounter++;
        }
    }

    jsConsole.writeLine("Case sensitive result : " + resultCounter);
    console.log("Case sensitive result : " + resultCounter);
}