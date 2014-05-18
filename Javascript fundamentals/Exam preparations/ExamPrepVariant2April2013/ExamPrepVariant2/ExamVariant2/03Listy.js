function Solve(args) {
    function parseOperationStart(operationStart) {
        var indexOfWhiteSpace = operationStart.trim().indexOf(' '),
            name,
            func;

        if (indexOfWhiteSpace === -1) {
            name = operationStart;
            func = '';
        } else {
            name = operationStart.substring(0, indexOfWhiteSpace).trim();
            func = operationStart.substring(operationStart.length - 4).trim();
        }

        return {
            name: name,
            func: func
        }
    }

    function parseValue(valueString) {
        valueString = valueString.trim().substring(0, valueString.length - 1);

        var parts = valueString.split(',').map(function (item) {
            item = item.trim();
            if (isFinite(item)) {
                return parseInt(item);
            } else {
                return item.trim();
            }
        });

        return parts;
    }

    function evaluateOperation(name, scope) {
        var operation = scope[name];
        var newValues = [];

        for (var i = 0; i < operation.value.length; i += 1) {
            var variableName = operation.value[i];
            if (!isFinite(variableName)) {
                var variableValue = scope[variableName].value;
                newValues.push(variableValue)
            }
        }

        for (i = 0; i < newValues.length; i += 1) {
            operation.value.push(newValues[i]);
        }
    }

    function parseOperations(lines) {
        var operations = [];

        for (var i = 0; i < lines.length; i += 1) {
            var line = lines[i];

            //parts[0] -> variable + function
            var parts = line.split('[');
            var opertaion = parseOperationStart(parts[0]);
            var value = parseValue(parts[1]);
            opertaion.value = value;
            operations.push(opertaion);
        }

        //return [
        //    {
        //        operation: 'sum',
        //        value: '[1,2,3]',
        //        name: 'func'
        //    }
        //];
    }

    var lines = args.map(function (item) {
        item = item.trim();

        if (item.indexOf('def ') !== 0) {
            return item;
        }

        item = item.substr('def '.length).trim();
        return item;
    });

    var operations = parseOperations(lines);
    var scope = {};

    for (var i = 0; i < operations.length; i += 1) {
        var operation = operations[i];
        scope[operation.name] = operation
        evaluateOperation(operation.name, scope);
    }
}

var test1 = [
    'def func         sum[5, 3, 7, 2, 6, 3]',
    'def func2  [5, 3, 7, 2, 6, 3]',
    '         def  func3 min[func2]',
    'def        func4 max[5, 3, 7, 2, 6, 3]',
    'def func5 avg[5,       3, 7, 2, 6, 3]',
    'def func6          sum[func2, func3, func4 ]',
    'sum[func6, func4]'
];

Solve(test1);