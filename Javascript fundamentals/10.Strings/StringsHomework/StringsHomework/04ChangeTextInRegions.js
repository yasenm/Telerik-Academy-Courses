jsConsole.writeLine("You are given a text. Write a function that changes the text in all regions:");
jsConsole.writeLine("<upcase>text</upcase> to uppercase.");
jsConsole.writeLine("<lowcase>text</lowcase> to lowercase");
jsConsole.writeLine("<mixcase>text</mixcase> to mix casing(random)");
jsConsole.writeLine("Check console for results also F12");

var text = "We are \<mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.",
    pattern;

function change(text) {
    var newText = "";
    var newSub = "";
    var up_b = "<upcase>";
    var up_e = "</upcase>";
    var low_b = "<lowcase>";
    var low_e = "</lowcase>";
    var mix_b = "<mixcase>";
    var mix_e = "</mixcase>";

    var br1 = 0;
    for (var i = 0; i < text.length; i++) {
        if (text.substr(i, up_b.length) === up_b) {
            for (var j = i + up_b.length; j < text.length; j++) {
                i = j;
                if (text.substr(j, up_e.length) === up_e) {
                    break;
                }
                newText += text.substr(i, 1).toUpperCase();
            }
        }
        if (text.substr(i, low_b.length) === low_b) {
            for (var j = i + low_b.length; j < text.length; j++) {
                i = j;
                if (text.substr(j, low_e.length) === low_e) {
                    break;
                }
                newText += text.substr(i, 1).toLowerCase();
            }
        }
        if (text.substr(i, mix_b.length) === mix_b) {
            for (var j = i + mix_b.length; j < text.length; j++) {
                i = j;
                if (text.substr(j, mix_e.length) === mix_e) {
                    break;
                }
                if (Math.random() * 2 > 1) {
                    newText += text.substr(i, 1).toLowerCase();
                }
                else {
                    newText += text.substr(i, 1).toUpperCase();
                }
            }
        }
        newText += text.substr(i, 1);
    }
    return newText;
};

jsConsole.writeLine(change(text));
console.log(change(text));