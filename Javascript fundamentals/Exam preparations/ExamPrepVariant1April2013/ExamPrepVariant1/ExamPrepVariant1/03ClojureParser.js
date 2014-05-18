function Solve(args) {
    var associativeArr = {},
        fullRsult;

    for (var i = 0; i < args.length; i += 1) {
        args[i] = removeWhiteSpaces(args[i]);
        fullResult = calcInBrackets(args[i]);
        if ('Division by zero!' === fullResult) {
            return fullResult + ' At line:' + i;
        }
    }

    return fullResult;

    function calcInBrackets(bracketExpression) {
        var stringWithoutEndBrackets = removeWhiteSpaces(bracketExpression).trim();
        stringWithoutEndBrackets = stringWithoutEndBrackets.substr(1, stringWithoutEndBrackets.length - 2);
        var expression = stringWithoutEndBrackets.split(' ');
        var result = 0;

        if (expression[0] === 'def') {

            if (bracketExpression.substr(1, bracketExpression.length - 2).indexOf('(') > 0) {
                var bracExp = stringWithoutEndBrackets.substring(stringWithoutEndBrackets.indexOf('(') - 1, stringWithoutEndBrackets.lastIndexOf(')') + 1);
                //if (bracExp.indexOf('(') === bracExp.lastIndexOf('(')) {
                //    bracExp = stringWithoutEndBrackets.split('(');
                //}

                associativeArr[expression[1]] = calcInBrackets(bracExp);
            } else {
                associativeArr[expression[1]] = parseFloat(expression[2]);
            }
        }
        if (expression[0] === '+') {
            for (var j = 1; j < expression.length; j += 1) {
                var wasInAssociativeArr = false;

                for (var key in associativeArr) {
                    if (expression[j] === key) {
                        result += parseFloat(associativeArr[key]);
                        wasInAssociativeArr = true;
                        break;
                    }
                }

                if (wasInAssociativeArr) {
                    continue;
                }
                result += parseFloat(expression[j]);
            }
            return result;
        }

        if (expression[0] === '-') {
            for (var j = 1; j < expression.length; j += 1) {
                var wasInAssociativeArr = false;

                for (var key in associativeArr) {
                    if (expression[j] === key) {
                        result -= parseFloat(associativeArr[key]);
                        wasInAssociativeArr = true;
                        break;
                    }
                }

                if (j === 1) {
                    result *= (-1);
                }
                if (wasInAssociativeArr) {
                    continue;
                }
                result -= parseFloat(expression[j]);
                if (j === 1) {
                    result *= (-1);
                }
            }
            return result;
        }

        if (expression[0] === '/') {
            for (var j = 1; j < expression.length; j += 1) {
                if (j === 1) {
                    var wasKey = false;
                    for (var key in associativeArr) {
                        if (expression[j] === key) {
                            result = parseFloat(associativeArr[key]);
                            wasKey = true;
                            break;
                        }
                    }
                    if (!wasKey) {
                        result = expression[1];
                    }
                    continue;
                }
                var wasInAssociativeArr = false;

                for (var key in associativeArr) {
                    if (expression[j] === key) {
                        result /= parseFloat(associativeArr[key]);
                        wasInAssociativeArr = true;
                        break;
                    }
                }
                if (wasInAssociativeArr) {
                    continue;
                }
                result /= parseFloat(expression[j]);
                if (result === Infinity || result === -Infinity) {
                    return 'Division by zero!';
                }
            }
            return result;
        }
        if (expression[0] === '*') {
            result = 1;
            for (var j = 1; j < expression.length; j += 1) {
                var wasInAssociativeArr = false;

                for (var key in associativeArr) {
                    if (expression[j] === key) {
                        result *= parseFloat(associativeArr[key]);
                        wasInAssociativeArr = true;
                        break;
                    }
                }
                if (wasInAssociativeArr) {
                    continue;
                }
                result *= parseFloat(expression[j]);
            }
            return result;
        }
    }

    console.log(associativeArr);

    function removeWhiteSpaces(str) {
        var i,
            lastWhiteSpace = false,
            result = '';

        for (i = 0; i < str.length; i += 1) {
            if (str[i] === ' ') {
                if (lastWhiteSpace) {
                    continue;
                }

                lastWhiteSpace = true;
                result += str[i];
            } else {
                lastWhiteSpace = false;
                result += str[i];
            }
        }

        return result;
    }
}

//var args1 = [
//    '(def func 10)',
//    '(def newFunc (+  func 2))',
//    '(def sumFunc (+ func func newFunc 0 0 0))',
//    '(* sumFunc 2)'
//];

//console.log(Solve(args1));