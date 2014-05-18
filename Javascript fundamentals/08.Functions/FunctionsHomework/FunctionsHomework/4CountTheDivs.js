jsConsole.writeLine("Write a function to count the number of divs on the web page.");
jsConsole.writeLine("Check console for results also F12");

function countTheDivs() {
    var divs = document.getElementsByTagName('div');
    return divs.length;
}

function countTheDivsClick() {
    jsConsole.writeLine(countTheDivs());
    console.log(countTheDivs());
};
