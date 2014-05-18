jsConsole.writeLine("Sorting an array means to arrange its elements in increasing order.");
jsConsole.writeLine(" Write a script to sort an array. Use the \"selection sort\"");
jsConsole.writeLine("algorithm: Find the smallest element, move it at the first position, find the");
jsConsole.writeLine("smallest from the rest, move it at the second position");
jsConsole.writeLine("Check console for results also F12");

var sequence = [];

var printArray = function (array) {
    jsConsole.writeLine("Sequence : " + array.join(", "));
    console.log("Sequence : " + array.join(", "));
    jsConsole.writeLine("");
}

var addNumberToSequence = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseInt(userInput);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("");
        jsConsole.writeLine("Entered value is NaN try with new one!");
        console.log("");
        console.log("Entered value is NaN try with new one!");
    } else {
        sequence.push(parsedInput);

        if (sequence.length < 2) {
            jsConsole.writeLine("Sequence is : ");
            console.log("Sequence is : ");
        }

        jsConsole.writeLine(userInput + ",")
        console.log(userInput + ",")
    }
};


var selectionSortArray = function () {
    printArray(sequence);

    for (var i = 0; i < sequence.length; i++) {
        var minValue = Number.MAX_VALUE;
        var minValueIndex = 0;

        for (var j = i; j < sequence.length; j++) {
            if (minValue > sequence[j]) {
                minValue = sequence[j]
                minValueIndex = j;
            }
        }

        sequence.splice(minValueIndex, 1);
        sequence.splice(i, 0, minValue);
    }

    jsConsole.writeLine("Result is : ");
    console.log("Result is : ");
    printArray(sequence);
};
