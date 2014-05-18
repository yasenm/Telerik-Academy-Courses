jsConsole.writeLine("Check if point entered is within circle [0,5];");
jsConsole.writeLine("Check console for results also F12");

var checkInCircle = function () {
    var xPointCoor = document.getElementById("xCoor").value;
    var parsedXPointCoor = parseFloat(xPointCoor);
    var yPointCoor = document.getElementById("yCoor").value;
    var parsedYPointCoor = parseFloat(yPointCoor);

    if (isNaN(parsedXPointCoor) || isNaN(parsedYPointCoor)) {
        jsConsole.writeLine("Entered values is NaN try with new one!")
        console.log("Entered values is NaN try with new one!")
    } else {
        var hyponuseTriangle = Math.sqrt(Math.pow(parsedXPointCoor, 2) + Math.pow(parsedYPointCoor, 2));

        jsConsole.writeLine(hyponuseTriangle < 5 ? "Within circle!" : "Out of circle!");
        console.log(hyponuseTriangle < 5 ? "Within circle!" : "Out of circle!");
    }
};