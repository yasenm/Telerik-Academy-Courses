jsConsole.writeLine("Write a function that formats a string using placeholders:");
jsConsole.writeLine("");
jsConsole.writeLine("var str = stringFormat(\"Hello {0}!\",\"Peter\");");
jsConsole.writeLine("//str = \"Hello Peter!\";");
jsConsole.writeLine("");
jsConsole.writeLine("The function should work with up to 30 placeholders and all types");
jsConsole.writeLine("");
jsConsole.writeLine("var format = \"{0}, {1}, {0} text {2}\";");
jsConsole.writeLine("var str = stringFormat(format,1,\"Pesho\",\"Gosho\");");
jsConsole.writeLine("//str = \"1, Pesho, 1 text Gosho\"");
jsConsole.writeLine("Check console for results also F12 !!!!!!!!!!!!! WORKS PERFECTLY IN FIREFOX!");

function stringFormat(str) {
    var i,
        result = str;

    if (arguments.length <= 1) {
        result = str;
        return result;
    }

    for (i = arguments.length - 1; i >= 1; i -= 1) {
        var placeholder = '{' + (i - 1) + '}';
        result = result.replace(placeholder, arguments[i]);
    }

    return result;
}


function findTimesSubstring(str) {
    pattern = new RegExp('{0}', 'gi');
    var matches = str.match(pattern);
    return matches.length;
}

//var sometext1 = stringFormat("Hello {0}!", "Peter");
//jsConsole.writeLine("");
//jsConsole.writeLine("String is : \"Hello {0}!\", \"Peter\"");
//jsConsole.writeLine("result is : ");
//jsConsole.writeLine(sometext1);
var format2 = "{0}, {1}, {0} text {2}";
var sometext2 = stringFormat(format2, 1, 'Pesho', 'Gosho');
jsConsole.writeLine("");
jsConsole.writeLine("String is : \"{0}, {1}, {0} text {2}\", 'Pesho','Gosho'");
jsConsole.writeLine("result is : ");
jsConsole.writeLine(sometext2);
console.log("");
console.log("String is : \"{0}, {1}, {0} text {2}\", 'Pesho','Gosho'");
console.log("result is : ");
console.log(sometext2);