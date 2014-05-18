jsConsole.writeLine("Write a program that finds the most frequent number in an array. Example:");
jsConsole.writeLine("");
jsConsole.writeLine("{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)");
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
            jsConsole.writeLine("Sequence is : ")
            console.log("Sequence is : ")
        }

        jsConsole.writeLine(userInput + ",")
        console.log(userInput + ",")
    }
};


var mostFrequentElement = function () {
    printArray(sequence);
    var workArray = sequence,
        frequentNumber,
        maxCount = 0,
        i;

    for (i = 0; i < workArray.length; i++) {
        var counter = 1;

        for (var j = i + 1; j < workArray.length; j++) {
            if (workArray[i] === workArray[j]) {
                counter++;
                workArray.splice(j, 1);
                j--;
            }
        }

        if (maxCount < counter) {
            maxCount = counter;
            frequentNumber = workArray[i];
        }
    }

    var resultArray = [];

    for (i = 0; i < maxCount; i++) {
        resultArray.push(frequentNumber);
    }

    jsConsole.writeLine("Result is : " + maxCount + " times");
    console.log("Result is : " + maxCount + " times");
    printArray(resultArray);
};
