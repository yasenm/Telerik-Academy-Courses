jsConsole.writeLine("Write a program that finds the greatest of given 5 variables.");
jsConsole.writeLine("Check console for results also F12");

var biggestOutOf5Variables = function () {
    var firstInt = document.getElementById("firstInt").value;
    var parsedFirstInt = parseFloat(firstInt);
    var secondInt = document.getElementById("secondInt").value;
    var parsedSecondInt = parseFloat(secondInt);
    var thirdInt = document.getElementById("thirdInt").value;
    var parsedThirdInt = parseFloat(thirdInt);
    var fourthInt = document.getElementById("fourthInt").value;
    var parsedFourthInt = parseFloat(fourthInt);
    var fifthInt = document.getElementById("fifthInt").value;
    var parsedFifthInt = parseFloat(fifthInt);

    if (isNaN(parsedFirstInt) || isNaN(parsedSecondInt) || isNaN(parsedThirdInt) ||
        isNaN(parsedFourthInt) || isNaN(parsedFifthInt)) {
        jsConsole.writeLine("Entered values are NaN try with new ones!");
        console.log("Entered values are NaN try with new ones!");
    } else {
        var array = [];

        array.push(parsedFirstInt);
        array.push(parsedSecondInt);
        array.push(parsedThirdInt);
        array.push(parsedFourthInt);
        array.push(parsedFifthInt);

        array.sort(function (a, b) { return a - b });
        jsConsole.writeLine("Greatest value is : " + array[4]);
    }
};