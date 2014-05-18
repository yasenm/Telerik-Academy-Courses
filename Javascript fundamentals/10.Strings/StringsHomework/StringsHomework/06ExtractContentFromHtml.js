jsConsole.writeLine("Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags:");
jsConsole.writeLine("Check console for results also F12");


function extractTextContent() {
    var content = document.getElementsByTagName("html")[0].innerText;
    jsConsole.writeLine(content + "<br/>");
    console.log(content + "<br/>");
};