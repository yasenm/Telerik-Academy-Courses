function Solve(args) {
    function makeMatrix(rows, cols) {
        var value = 1;
        var matrix = new Array(rows);

        for (var i = 0; i < matrix.length; i += 1) {
            matrix[i] = new Array(cols);

            for (var j = 0; j < matrix[i].length; j += 1) {
                matrix[i][j] = value;
                value += 1;
            }
        }

        return matrix;
    };

    var jumpResult;

    function Solving(args) {
        var N = parseInt(args[0].split(' ')[0]);
        var M = parseInt(args[0].split(' ')[1]);
        var matrix = makeMatrix(N, M);
        var newArgs = [];

        var startRow = parseInt(args[1].split(' ')[0])
        var startCol = parseInt(args[1].split(' ')[1])
        var result = parseInt(matrix[startRow, startCol]);

        for (var i = 0; i < args.length - 2; i++) {
            newArgs.push(args[i + 2]);
        }

        jump(startRow, startCol, result, newArgs, N, M, matrix);
        return jumpResult;
    };

    function jump(startRow, startCol, result, args, N, M, matrix) {
        for (var i = 0; i < args.length; i += 1) {
            startRow += parseInt(args[i].split(' ')[0]);
            startCol += parseInt(args[i].split(' ')[1]);

            if (startRow >= N || startRow < 0 || startCol >= M || startCol < 0) {
                jumpResult = "escaped " + result;
                return;
            } else if (matrix[startRow][startCol] === 'checked') {
                jumpResult = 'caught ' + result;
                return;
            }

            var currentAdd = matrix[startRow][startCol];
            matrix[startRow][startCol] = 'checked';
            result += currentAdd;
        }

        jump(startRow, startCol, result, args, N, M, matrix);
    };

    Solving(args);
    return jumpResult;
}
var args1 = ['6 7 3', '0 0', '2 2', '-2 2', '3 -1'];
console.log(Solve(args1));