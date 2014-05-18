jsConsole.writeLine("Write functions for working with shapes in  standard Planar coordinate system  ");
jsConsole.writeLine("---> Points are represented by coordinates P(X, Y)");
jsConsole.writeLine("---> Lines are represented by two points, marking their beginning and ending");
jsConsole.writeLine("---> *** L(P1(X1,Y1), P2(X2,Y2))");
jsConsole.writeLine("---> Calculate the distance between two points");
jsConsole.writeLine("---> Check if three segment lines can form a triangle");
jsConsole.writeLine("Check console for results also F12");

function Point(coorX, coorY) {
    this.x = coorX;
    this.y = coorY;

    this.calcDistanceToPoint = function (point) {
        var result;
        result = Math.sqrt(Math.pow((point.x - this.x), 2) + Math.pow((point.y - this.y), 2))
        return result;
    };
};

function Line(fPoint, sPoint) {
    this.firstPoint = fPoint;
    this.secondPoint = sPoint;

    this.GetLineLength = function () {
        return this.firstPoint.calcDistanceToPoint(this.secondPoint);
    };

    this.CheckTrianglePossible = function (firstLine, secondLine) {
        var result = false;
        var thisLen = this.GetLineLength();
        var firstLineLen = firstLine.GetLineLength();
        var secondLineLen = secondLine.GetLineLength();

        if (thisLen + firstLineLen > secondLineLen &&
            thisLen + secondLineLen > firstLineLen &&
            secondLineLen + secondLineLen > thisLen) {
            result = true;
        }

        return result;
    };
};

var point1 = new Point(7, 18);
var point2 = new Point(24, 8);

jsConsole.writeLine(point1.calcDistanceToPoint(point2));
console.log(point1.calcDistanceToPoint(point2));

var line1 = new Line(new Point(0, 0), new Point(0, 15))
var line2 = new Line(new Point(0, 0), new Point(0, 5))
var line3 = new Line(new Point(0, 0), new Point(0, 5))

jsConsole.writeLine(line1.CheckTrianglePossible(line2, line3));
console.log(line1.CheckTrianglePossible(line2, line3));