jsConsole.writeLine("Write a script that finds the max and min number from a sequence of numbers.");
jsConsole.writeLine("Check console for results also F12");

var sequence = [];
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

var findMaxFromSequence = function () {
    jsConsole.writeLine("Sequence is : ")
    console.log("Sequence is : ")

    for (var i = 0; i < sequence.length; i++) {
        jsConsole.write(sequence[i] + ",");
        console.log(sequence[i] + ",");
    }
    jsConsole.writeLine("");

    sequence.sort(function (a, b) { return a - b });

    jsConsole.writeLine("Smallest is : " + sequence[0]);
    console.log("Smallest is : " + sequence[0]);
    jsConsole.writeLine("Biggest is : " + sequence[sequence.length - 1]);
    console.log("Biggest is : " + sequence[sequence.length - 1]);
};