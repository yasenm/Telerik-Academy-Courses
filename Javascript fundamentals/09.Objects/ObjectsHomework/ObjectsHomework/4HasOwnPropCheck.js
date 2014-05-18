jsConsole.writeLine("Write a function that checks if a given object contains a given property");
jsConsole.writeLine("");
jsConsole.writeLine("Check console for results also F12");

function checkForProperty(object, propName) {
    var result = false;

    for (var prop in object) {
        if (object[propName] === object[prop]) {
            result = true;
            break;
        }
    }

    return result;
}

function Point(coorX, coorY) {
    this.x = coorX;
    this.y = coorY;
}

var point1 = new Point(1, 1);

jsConsole.writeLine("Checking if Point object that has properties x and y has a 'x' property : " + checkForProperty(point1, 'x'))
console.log("Checking if Point object that has properties x and y has a 'x' property : " + checkForProperty(point1, 'x'));
jsConsole.writeLine("Checking if Point object that has properties x and y has a 'z' property : " + checkForProperty(point1, 'z'))
console.log("Checking if Point object that has properties x and y has a 'z' property : " + checkForProperty(point1, 'z'));