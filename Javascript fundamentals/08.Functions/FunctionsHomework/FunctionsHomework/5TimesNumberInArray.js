jsConsole.writeLine("Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.");
jsConsole.writeLine("Check console for results also F12");

var sequence = new Array(15),
    userValueInput,
    i;

function makeArray() {
    for (var i = 0; i < sequence.length; i++) {
        sequence[i] = parseInt(Math.random() * 20);
    }
};

function printArray(array) {
    jsConsole.writeLine("Sequence : " + array.join(", "));
    console.log("Sequence : " + array.join(", "));
    jsConsole.writeLine("");
};

makeArray();
printArray(sequence);

function getValue() {
    var parsedInput = parseInt(document.getElementById("userInput").value);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("");
        jsConsole.writeLine("Entered value is NaN try with new one!");
        console.log("");
        console.log("Entered value is NaN try with new one!");
    } else {
        userValueInput = parsedInput;
    }
};

function findOccurences(input) {
    var counter = 0;

    for (i = 0; i < sequence.length; i++) {
        if (sequence[i] === input) {
            counter++;
        }
    }

    return "Occurences in array of " + userValueInput + " is : " + counter + " times";
};

function timesNumberInArrayClick() {
    getValue();

    var result = findOccurences(userValueInput);

    jsConsole.writeLine(result);
    console.log(result);
};
