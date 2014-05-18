jsConsole.writeLine("Write a script that finds the maximal sequence of equal elements in an array.");
jsConsole.writeLine("Check console for results also F12");

var sequence = [];

var printArray = function (array) {
    jsConsole.write("Sequence is : " + array.join(", "));
    console.log("Sequence is : " + array.join(", "));
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
            jsConsole.writeLine("Sequence is : ")
            console.log("Sequence is : ")
        }

        jsConsole.writeLine(userInput + ",")
        console.log(userInput + ",")
    }
};


var findMaxSequenceOfEqual = function () {
    printArray(sequence);
    var counter = 1;
    var resultCounter = 0;
    var resultInt;

    for (var i = 0; i < sequence.length - 1; i++) {
        if (sequence[i] === sequence[i + 1]) {
            counter++;
        } else {
            counter = 1;
        }

        if (resultCounter < counter) {
            resultCounter = counter;
            resultInt = sequence[i];
        }
    }

    var resultArray = [];

    for (var j = 0; j < resultCounter; j++) {
        resultArray.push(resultInt);
    }

    jsConsole.writeLine("Result is : ");
    console.log("Result is : ");
    printArray(resultArray);
};
