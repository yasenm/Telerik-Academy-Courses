jsConsole.writeLine("Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.");
jsConsole.writeLine("Use the function from the previous exercise.");
jsConsole.writeLine("Check console for results also F12");

var sequence = new Array(15),
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

function findIndexOfBiggerNeighbor(array) {
    if (array.length <= 1) {
        return "Array is too small need atleast 3 elements";
    }

    for (var index = 1; index < array.length - 1; index++) {
        if (array[index] > array[index - 1] &&
            array[index] > array[index + 1]) {
            return index;
            break;
        }
    }

    return -1;
};

function firstIndexClick() {
    var result = findIndexOfBiggerNeighbor(sequence);
    var resultOfSorted = findIndexOfBiggerNeighbor(sequence.sort(function (a, b) { return a - b }));

    jsConsole.writeLine("Index of first neighbor bigger than neighbors is : " + result);
    console.log("Index of first neighbor bigger than neighbors is : " + result);
    jsConsole.writeLine("Index in ordered array would be : " + resultOfSorted);
    console.log("Index in ordered array would be : " + resultOfSorted);
    jsConsole.writeLine("Refresh page to see new result since when we order the array it stays ordered and next click will show -1 on both results.")
    console.log("Refresh page to see new result since when we order the array it stays ordered and next click will show -1 on both results.")
};
