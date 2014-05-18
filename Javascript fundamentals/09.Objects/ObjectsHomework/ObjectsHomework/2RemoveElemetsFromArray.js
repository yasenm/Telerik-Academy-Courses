jsConsole.writeLine("Write a function that removes all elements with a given value");
jsConsole.writeLine("");
jsConsole.writeLine("Attach it to the array type");
jsConsole.writeLine("Read about prototype and how to attach methods");
jsConsole.writeLine("Check console for results also F12");

Array.prototype.remove = function (item) {
    for (var i = 0; i < this.length; i += 1) {
        if (this[i] === item) {
            this.splice(i, 1);
            i -= 1;
        }
    }
};

var arr = [1, 2, 3, 4, 5, 6, 7];
arr.remove(3);

jsConsole.writeLine(arr.join(", "));
console.log(arr.join(", "));