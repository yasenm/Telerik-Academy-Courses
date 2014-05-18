jsConsole.writeLine("Write a function for extracting all email addresses from given text. All substrings that");
jsConsole.writeLine("match the format <identifier>@<host>…<domain> should be recognized as emails.");
jsConsole.writeLine("Return the emails as array of strings.");
jsConsole.writeLine("Check console for results also F12");

var text = "Write a function for extracting all email pesho@abvbg addresses from given text." +
		"All substrings pesho@abv.bg that match the format <identifier>@<host>…<domain> should " +
		"be recognized as emails. Return the emails as array of strings." +
		" gosho@yahoo.com haralampi@gmail.com";

jsConsole.writeLine(text);
console.log(text);

function findMails(str) {
    var pattern = new RegExp(/[a-z0-9\.\-\_]+@[a-z\-]+\.[a-z]{2,3}/gi);
    var result = str.match(pattern);
    return result;
}

var matches = findMails(text);

jsConsole.writeLine(matches.join(' | '));
console.log(text);