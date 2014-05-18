jsConsole.writeLine("Check if point is within circle");
jsConsole.writeLine("Check console for results also F12");

var checkForPointInRectAndCircle = function () {
    var x = document.getElementById("coorX").value;
    var parsedX = parseFloat(x);
    var y = document.getElementById("coorY").value;
    var parsedY = parseFloat(y);

    // circle parameters
    var circleCenterX = 1;
    var circleCenterY = 1;
    var circleRadius = 3;

    // rectangle data
    var rectStartX = -1;
    var rectStartY = 1;
    var rectEndX = 5;
    var rectEndY = -1;

    if (isNaN(parsedX) || isNaN(parsedY)) {
        jsConsole.writeLine("Entered values is NaN try with new one!")
        console.log("Entered values is NaN try with new one!")
    } else {
        
        // first check if point is within the circle
        var newCircleCenterX = Math.pow((x - circleCenterX), 2);
        var newCircleCenterY = Math.pow((y - circleCenterX), 2);
        var circleRadiusPowed = Math.pow(circleRadius, 2);
        var withinACircle = newCircleCenterX + newCircleCenterY <= circleRadiusPowed;

        jsConsole.writeLine(withinACircle ? "Point is within the circle" : "Point ain't in the circle");

        if (x < rectStartX || x > rectEndX ||
            y < rectStartY || y < rectEndY) {
            jsConsole.writeLine("Point is outside of rectangle");
            console.log("Point is outside of rectangle");
        } else {
            jsConsole.writeLine("Point is within rectangle");
            console.log("Point is within rectangle");
        }
    }
};