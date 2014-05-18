jsConsole.writeLine("Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).");
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

function checkElementAtIndex(indexInput) {
    var result = false;

    if (sequence.length <= 1) {
        return "Array is too small need atleast 2 elements";
    }
    if (indexInput < 0 || indexInput >= sequence.length) {
        result = false;
    } else {
        if (indexInput === 0) {
            if (sequence[indexInput] > sequence[indexInput + 1]) {
                result = "only right neighbor, which is lesser."
            } else {
                result = "only right neighbor, which is bigger."
            }
        } else if (indexInput === sequence.length - 1) {
            if (sequence[indexInput] > sequence[indexInput - 1]) {
                result = "only left neighbor, which is lesser."
            } else {
                result = "only left neighbor, which is bigger."
            }
        } else {
            if (sequence[indexInput] > sequence[indexInput - 1] &&
                sequence[indexInput] > sequence[indexInput + 1]) {
                result = true;
            }
        }
    }

    return result;
};

function timesNumberInArrayClick() {
    getValue();

    var result = checkElementAtIndex(userValueInput);

    jsConsole.writeLine("Result is : " + result);
    console.log("Result is : " + result);
};
