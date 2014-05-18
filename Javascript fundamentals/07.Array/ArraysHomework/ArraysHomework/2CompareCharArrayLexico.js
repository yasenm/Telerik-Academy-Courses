jsConsole.writeLine("Write a script that compares two char arrays lexicographically(letter by letter).");
jsConsole.writeLine("Check console for results also F12");

var arr1 = ['H', 'e', 'l', 'l', 'o', 'm', 'y', 'n', 'a', 'm', 'e', 'i', 's', 'G', 'a', 'n', 'i', 'o'];
var arr2 = ['H', 'e', 'l', 'u', 'o', 'm', 'y', 'n'];

jsConsole.writeLine("First array is : " + "<br />" + arr1);
jsConsole.writeLine("Second array is : " + "<br />" + arr2 + "<br />");

var arrAll;
var counter = 0;

if (arr1.length > arr2.length) {
    arrAll = arr2.length;
} else {
    arrAll = arr1.length;
}

arrCh = arrAll;

for (var i = 0; i < arrCh ; i++) {
    if (arr1[i] !== arr2[i]) {
        jsConsole.writeLine("Arrays not equal");
        break;
    } else {
        counter = counter + 1;

        if (counter === arrCh) {
            jsConsole.writeLine("Arrays are equal");
        }
    }
};
