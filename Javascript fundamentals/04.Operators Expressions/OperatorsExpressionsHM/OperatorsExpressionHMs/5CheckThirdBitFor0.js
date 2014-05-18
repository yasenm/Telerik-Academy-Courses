jsConsole.writeLine("Check console for results also F12");

var checkThirdBitFor0 = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseFloat(userInput);

    if (isNaN(parsedInput)) {
        jsConsole.writeLine("Entered value is NaN try with new one!")
        console.log("Entered value is NaN try with new one!")
    } else {
        var bitPosition = 3;
        var mask = 1 << bitPosition;
        var result = (mask & parsedInput) >> bitPosition;

        jsConsole.writeLine("Bit representation of " + parsedInput + " is : " + parsedInput.toString(2));
        jsConsole.writeLine("Third bit right to left is : '" + result + "';");

        cosnole.log("Bit representation of " + parsedInput + " is : " + parsedInput.toString(2));
        cosnole.log("Third bit right to left is : '" + result + "';");
    }
};