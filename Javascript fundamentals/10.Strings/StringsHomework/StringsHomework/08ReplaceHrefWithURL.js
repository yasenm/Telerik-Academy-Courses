jsConsole.writeLine("Write a JavaScript function that replaces in a HTML document given as string all the tags <a href=\"…\">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:");
jsConsole.writeLine("Check console for results also F12");

var text = document.getElementById('content').innerHTML,
    pattern;

jsConsole.writeLine(text);
console.log(text);

function replaceHrefWithURL(str) {
    var result = str.replace(/<a href=/gi, '[URL=');
    result = result.replace(/">/gi, '"]');
    result = result.replace(/<\/a>/gi, '[/URL]');
    result = result.replace(/\/a>/gi, '/URL]');
    return result;
}

jsConsole.writeLine(replaceHrefWithURL(text));
console.log(replaceHrefWithURL(text));