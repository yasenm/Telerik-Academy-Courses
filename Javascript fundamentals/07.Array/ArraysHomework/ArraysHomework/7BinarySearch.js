jsConsole.writeLine("Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).");
jsConsole.writeLine("Check console for results also F12");

var sequence = new Array(20),
    valueToCheckIndex,
    i;
var makeArray = function () {
    for (var i = 0; i < sequence.length; i++) {
        sequence[i] = parseInt(Math.random() * 60);
    }

    sequence.sort(function (a, b) { return a - b });
}

var printArray = function (array) {
    jsConsole.writeLine("Sequence : " + array.join(", "));
    console.log("Sequence : " + array.join(", "));
    jsConsole.writeLine("");
}

makeArray();
printArray(sequence);

var getValue = function () {
    var userInput = document.getElementById("userInput").value,
        parsedInput = parseInt(userInput);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("");
        jsConsole.writeLine("Entered value is NaN try with new one!");
        console.log("");
        console.log("Entered value is NaN try with new one!");
    } else {
        valueToCheckIndex = parsedInput;
    }
}


var binarySearch = function () {
    getValue();
    var lowerIndex = 0;
    var higherIndex = 20;
    var resultIndex;

    while (true) {
        if (valueToCheckIndex === sequence[parseInt((lowerIndex + higherIndex) / 2)]) {
            resultIndex = parseInt((lowerIndex + higherIndex) / 2);
            break;
        }
        if (valueToCheckIndex > sequence[parseInt((lowerIndex + higherIndex) / 2)]) {
            lowerIndex = (lowerIndex + higherIndex) / 2;
        } else {
            higherIndex = (lowerIndex + higherIndex) / 2;
        }
    }

    jsConsole.writeLine("Index of '" + valueToCheckIndex + "' is : " + resultIndex + ";");
};
