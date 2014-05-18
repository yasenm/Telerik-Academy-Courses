jsConsole.writeLine("Write a function that makes a deep copy of an object");
jsConsole.writeLine("--> The function should work for both primitive and reference types");
jsConsole.writeLine("Check console for results also F12");

function printObj(obj) {
    for (var i in obj) {
        console.log(i + " -- > " + obj[i])
    }
};

function DeepCopy(inputObj) {
    var resultObj,
        property;

    if (inputObj instanceof Array) {
        resultObj = [];
    }

    if (inputObj instanceof Date) {
        resultObj = new Date;
    }

    if (inputObj instanceof Object) {
        resultObj = {};
    }

    for (property in inputObj) {
        if (typeof inputObj[property] === 'number' ||
            typeof inputObj[property] === 'boolean' ||
            typeof inputObj[property] === 'undefined' ||
            typeof inputObj[property] === 'string' ||
            typeof inputObj[property] === null) {
            resultObj[property] = inputObj[property];
        } else {
            resultObj[property] = DeepCopy(inputObj[property])
        }
    }

    return resultObj;
}

var obj1 = {
    x: 1,
    y: 2
};
var obj2 = DeepCopy(obj1);

printObj(obj1);
printObj(obj2);
obj1.name = "pesho";
console.log("------------------")
printObj(obj1);
printObj(obj2);

//console.log(obj1.join(", "));
//console.log(obj2.join(", "));
//obj1[0] = 10;
//obj1[15] = 9;
//console.log(obj1.join(", "));
//console.log(obj2.join(", "));