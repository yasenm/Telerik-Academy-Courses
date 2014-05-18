jsConsole.writeLine("Sort 3 real values in descending order using nested if statements.");
jsConsole.writeLine("Check console for results also F12");

var sortThreeValuesDescending = function () {
    var firstInt = document.getElementById("firstInt").value;
    var parsedFirstInt = parseFloat(firstInt);
    var secondInt = document.getElementById("secondInt").value;
    var parsedSecondInt = parseFloat(secondInt);
    var thirdInt = document.getElementById("thirdInt").value;
    var parsedThirdInt = parseFloat(thirdInt);

    if (isNaN(parsedSecondInt) || isNaN(parsedFirstInt) || isNaN(parsedThirdInt)) {
        jsConsole.writeLine("Entered values are NaN try with new ones!")
        console.log("Entered values are NaN try with new ones!")
    } else {
        if (parsedFirstInt > parsedSecondInt) {
            if (parsedSecondInt > parsedThirdInt) {
                jsConsole.writeLine("Order is : " + parsedFirstInt + ", " + parsedSecondInt + ", " + parsedThirdInt + ";")
                console.log("Order is : " + parsedFirstInt + ", " + parsedSecondInt + ", " + parsedThirdInt + ";")
            } else {
                if (parsedThirdInt > parsedFirstInt) {
                    jsConsole.writeLine("Order is : " + parsedThirdInt + ", " + parsedFirstInt + ", " + parsedSecondInt + ";")
                    console.log("Order is : " + parsedThirdInt + ", " + parsedFirstInt + ", " + parsedSecondInt + ";")
                } else {
                    jsConsole.writeLine("Order is : " + parsedFirstInt + ", " + parsedThirdInt + ", " + parsedSecondInt + ";")
                    console.log("Order is : " + parsedFirstInt + ", " + parsedThirdInt + ", " + parsedSecondInt + ";")
                }
            }
        } else {
            if (parsedFirstInt > parsedThirdInt) {
                jsConsole.writeLine("Order is : " + parsedSecondInt + ", " + parsedFirstInt + ", " + parsedThirdInt + ";")
                console.log("Order is : " + parsedSecondInt + ", " + parsedFirstInt + ", " + parsedThirdInt + ";")
            } else {
                if (parsedThirdInt > parsedSecondInt) {
                    jsConsole.writeLine("Order is : " + parsedThirdInt + ", " + parsedSecondInt + ", " + parsedFirstInt + ";")
                    console.log("Order is : " + parsedThirdInt + ", " + parsedSecondInt + ", " + parsedFirstInt + ";")
                } else {
                    jsConsole.writeLine("Order is : " + parsedSecondInt + ", " + parsedThirdInt + ", " + parsedFirstInt + ";")
                    console.log("Order is : " + parsedSecondInt + ", " + parsedThirdInt + ", " + parsedFirstInt + ";")
                }
            }
        }
    }
};