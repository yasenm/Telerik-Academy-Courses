function Solve(args) {
    var result = parseFloat(args[1]),
        i,
        j;

    for (i = 1; i < args.length; i += 1) {
        var currentSum = 0;
        for (j = i; j < args.length; j += 1) {
            currentSum += parseFloat(args[j]);
            if (result < currentSum) {
                result = currentSum;
            }
        }
    }

    return result;
}

var args1 = ['8', '1', '6', '-9', '4', '4', '-2', '10', '-1'];
var args2 = ['6', '1', '3', '-5', '8', '7', '-6'];
var args3 = ['9', '-9', '-8', '-8', '-7', '-6', '-5', '-1', '-7', '-6'];

console.log(Solve(args1));
console.log(Solve(args2));
console.log(Solve(args3));
