jsConsole.writeLine("Write a program that extracts from a given text all palindromes, e.g. \"ABBA\", \"lamal\", \"exe\".");
jsConsole.writeLine("Check console for results also F12");

var text = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";

jsConsole.writeLine("Text is : ");
jsConsole.writeLine(text);
console.log("Text is : ");
console.log(text);

function findPalindromes(str) {
    var pattern = new RegExp(/(,|\.|\s)/g);
    var splitedText = str.split(pattern);
    var result = [];

    for (var i = 0; i < splitedText.length; i+=1) {
        if (isPalindrome(splitedText[i])) {
            result.push(splitedText[i]);
        }
    }

    return result;
}

function isPalindrome(word) {
    var result = true;

    if (word.length <=1) {
        return false;
    }

    for (var i = 0, len = parseInt(word.length/2); i < len; i+=1) {
        if (word[i] !== word[word.length - 1 - i]) {
            result = false;
            break;
        }
    }

    return result;
}

var palindromes = findPalindromes(text);

jsConsole.writeLine("Result is : ");
jsConsole.writeLine(palindromes.join(' | '));
console.log("Result is : ");
console.log(palindromes.join(' | '));