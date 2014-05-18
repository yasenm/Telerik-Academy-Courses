jsConsole.writeLine("Write a JavaScript function that finds how many times a substring is contained");
jsConsole.writeLine("in a given text (perform case insensitive search).");
jsConsole.writeLine("Check console for results also F12");

var userValue,
    text,
    pattern;

function getValue() {
    userValue = document.getElementById("userInput").value;
    text = document.getElementById("textContainer").innerHTML;
}

function findTimesSubstring() {
    pattern = new RegExp(userValue,'gi');
    var matches = text.match(pattern);
    return matches.length;
}

function findTimesSubstringClickEv() {
    getValue();
    jsConsole.writeLine("Times found : " + findTimesSubstring());
    console.log("Times found : " + findTimesSubstring());
}