function Solve(args) {
    var result;
    var matrixRows = parseInt(args[0].split(' ')[0]);
    var matrixCols = parseInt(args[0].split(' ')[1]);

    var numberMatrix = makeNumberMatrix(matrixRows, matrixCols);
    var directionsMatrix = makeDirectionMatrix(args);

    var startRow = parseInt(args[1].split(' ')[0]);
    var startCol = parseInt(args[1].split(' ')[1]);
    var numberOfCells = 0;
    var currentResult = 0;

    function move(sRow, sCol) {
        if (sRow < 0 || sRow >= matrixRows || sCol < 0 || sCol >= matrixCols) {
            result = 'out ' + currentResult;
            return;
        }

        if (numberMatrix[sRow][sCol] === -1) {
            result = 'lost ' + numberOfCells;
            return;
        }

        numberOfCells++;
        currentResult += numberMatrix[sRow][sCol];
        numberMatrix[sRow][sCol] = -1;

        if (directionsMatrix[sRow][sCol] === 'u') {
            move(sRow - 1, sCol);
        } else if (directionsMatrix[sRow][sCol] === 'r') {
            move(sRow, sCol + 1);
        } else if (directionsMatrix[sRow][sCol] === 'd') {
            move(sRow + 1, sCol);
        } else if (directionsMatrix[sRow][sCol] === 'l') {
            move(sRow, sCol - 1);
        }
    }

    function makeNumberMatrix(mRows, mCols) {
        var resultMatrix = new Array(mRows);
        var inputNumber = 1;

        for (var i = 0; i < mRows; i += 1) {
            resultMatrix[i] = new Array(mCols);

            for (var j = 0; j < mCols; j += 1) {
                resultMatrix[i][j] = inputNumber;
                inputNumber++;
            }
        }

        return resultMatrix;
    }

    function makeDirectionMatrix(params) {
        var resultMatrix = new Array(matrixRows);

        for (var i = 2; i < params.length; i += 1) {
            resultMatrix[i - 2] = new Array(matrixCols);

            for (var j = 0; j < matrixCols; j += 1) {
                resultMatrix[i - 2][j] = params[i][j];
            }
        }

        return resultMatrix;
    }

    move(startRow, startCol);
    return result;
}

var args1 = [
    "3 4",
    "1 3",
    "lrrd",
    "dlll",
    "rddd"
];

var args2 = [
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "durlddud",
    "urrrldud",
    "ulllllll"
];

var args3 = [
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "lurlddud",
    "urrrldud",
    "ulllllll"
];

console.log(Solve(args1));
console.log(Solve(args2));
console.log(Solve(args3));