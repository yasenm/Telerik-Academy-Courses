var args1 = [1, 2, -3, 4, 4, 0, 1];//[7, 1, 2, -3, 4, 4, 0, 1];
var args2 = [6, 1, 3, -5, 8, 7, -6];
var args3 = [9, 1, 8, 8, 7, 6, 5, 7, 7, 6];

function solve(args) {
    var result = 0;
    if (args[0] <= args[1]) {
        result = 1;
    }
    for (var i = 1; i < args.length; i++) {
        if (parseInt(args[i - 1]) > parseInt(args[i])) {
            result++;
        }
    }

    return result;
}
console.log(solve(args1));
console.log(solve(args2));
console.log(solve(args3));
