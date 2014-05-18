jsConsole.writeLine("Write a script that allocates array of 20 integers and");
jsConsole.writeLine("initializes each element by its index multiplied by 5.");
jsConsole.writeLine("Print the obtained array on the console.");
jsConsole.writeLine("Check console for results also F12");

// function for array printing
var printArray = function (array) {
    jsConsole.writeLine(array.join(", "));
    console.log(array.join(", "));
};

// intializing the array
var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

// first print
jsConsole.writeLine("Not multiplied array:")
console.log("Not multiplied array:")
printArray(arr);

// multiplying ints in array
for (var i = 0; i < arr.length; i++) {
    arr[i] = arr[i] * 5;
}

// second print of multiplyed array ints
jsConsole.writeLine("Multiplied array:")
console.log("Multiplied array:")
printArray(arr);
