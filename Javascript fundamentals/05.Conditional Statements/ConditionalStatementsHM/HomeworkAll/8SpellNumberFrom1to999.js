jsConsole.writeLine("Write a program that converts a number in the range [0...999] to a text");
jsConsole.writeLine("corresponding to its English pronunciation. Examples:");
jsConsole.writeLine("    - 0  \"Zero\"");
jsConsole.writeLine("    - 273  \"Two hundred seventy three\"");
jsConsole.writeLine("    - 400  \"Four hundred\"");
jsConsole.writeLine("    - 501  \"Five hundred and one\"");
jsConsole.writeLine("    - 711  \"Seven hundred and eleven\"");
jsConsole.writeLine("Check console for results also F12");

var spellNumberFrom1to999 = function () {
    var userInput = document.getElementById("userInput").value;
    var parsedInput = parseInt(userInput);

    if (isNaN(parsedInput) || userInput.length > 3) {
        jsConsole.writeLine("Entered value is NaN or not number from 1 to 999 try with new entrie!")
        console.log("Entered value is NaN or not a single digit try with new entrie!")
    } else {
        var numForOnes = parseInt(parsedInput % 10);
        var numForTens = parseInt((parsedInput / 10) % 10);
        var numForHundreds = parseInt((parsedInput / 100) % 10);
        var strForOnes;
        var strFor10to19;
        var strForTens;
        var strForHunderds;

        if (parsedInput < 20) {
            switch (parsedInput) {
                case 0: strForOnes = "Zero"; break;
                case 1: strForOnes = "One"; break;
                case 2: strForOnes = "Two"; break;
                case 3: strForOnes = "Three"; break;
                case 4: strForOnes = "Four"; break;
                case 5: strForOnes = "Five"; break;
                case 6: strForOnes = "Six"; break;
                case 7: strForOnes = "Seven"; break;
                case 8: strForOnes = "Eight"; break;
                case 9: strForOnes = "Nine"; break;
                case 10: strForOnes = "Ten"; break;
                case 11: strForOnes = "Eleven"; break;
                case 12: strForOnes = "Twelve"; break;
                case 13: strForOnes = "Threeteen"; break;
                case 14: strForOnes = "Fourteen"; break;
                case 15: strForOnes = "Fiveteen"; break;
                case 16: strForOnes = "Sixteen"; break;
                case 17: strForOnes = "Seventeen"; break;
                case 18: strForOnes = "Eightteen"; break;
                case 19: strForOnes = "Nineteen"; break;
            }
            jsConsole.writeLine(parsedInput + " --> " + strForOnes);
        }
        else if (parsedInput >= 20 && parsedInput < 100) {
            switch (numForTens) {
                case 2: strForTens = "Twenty"; break;
                case 3: strForTens = "Thirty"; break;
                case 4: strForTens = "Fourty"; break;
                case 5: strForTens = "Fifty"; break;
                case 6: strForTens = "Sixty"; break;
                case 7: strForTens = "Seventy"; break;
                case 8: strForTens = "Eighty"; break;
                case 9: strForTens = "Ninety"; break;
            }
            if (numForOnes >= 1) {
                switch (numForOnes) {
                    case 1: strForOnes = "one"; break;
                    case 2: strForOnes = "two"; break;
                    case 3: strForOnes = "three"; break;
                    case 4: strForOnes = "four"; break;
                    case 5: strForOnes = "five"; break;
                    case 6: strForOnes = "six"; break;
                    case 7: strForOnes = "seven"; break;
                    case 8: strForOnes = "eight"; break;
                    case 9: strForOnes = "nine"; break;
                }
                jsConsole.writeLine(parsedInput + " --> " + strForTens + strForOnes);
            }
            else {
                jsConsole.writeLine(parsedInput + " --> " + strForTens);
            }
        }
        else if (parsedInput >= 100) {
            switch (numForHundreds) {
                case 1: strForHunderds = "One hundred"; break;
                case 2: strForHunderds = "Two hundred"; break;
                case 3: strForHunderds = "Three hundred"; break;
                case 4: strForHunderds = "Four hundred"; break;
                case 5: strForHunderds = "Five hundred"; break;
                case 6: strForHunderds = "Six hundred"; break;
                case 7: strForHunderds = "Seven hundred"; break;
                case 8: strForHunderds = "Eight hundred"; break;
                case 9: strForHunderds = "Nine hundred"; break;
            }
            if (numForTens >= 2) {
                switch (numForTens) {
                    case 2: strForTens = "twenty"; break;
                    case 3: strForTens = "thirty"; break;
                    case 4: strForTens = "fourty"; break;
                    case 5: strForTens = "fifty"; break;
                    case 6: strForTens = "sixty"; break;
                    case 7: strForTens = "seventy"; break;
                    case 8: strForTens = "eighty"; break;
                    case 9: strForTens = "ninety"; break;
                }
                switch (numForOnes) {
                    case 0: strForOnes = "."; break;
                    case 1: strForOnes = "one"; break;
                    case 2: strForOnes = "two"; break;
                    case 3: strForOnes = "three"; break;
                    case 4: strForOnes = "four"; break;
                    case 5: strForOnes = "five"; break;
                    case 6: strForOnes = "six"; break;
                    case 7: strForOnes = "seven"; break;
                    case 8: strForOnes = "eight"; break;
                    case 9: strForOnes = "nine"; break;
                }
                jsConsole.writeLine(parsedInput + " --> " + strForHunderds + " and " + strForTens + strForOnes);
            }
            else if (numForTens === 1) {
                switch (numForOnes) {
                    case 0: strFor10to19 = "ten"; break;
                    case 1: strFor10to19 = "eleven"; break;
                    case 2: strFor10to19 = "twelve"; break;
                    case 3: strFor10to19 = "threeteen"; break;
                    case 4: strFor10to19 = "fourteen"; break;
                    case 5: strFor10to19 = "fiveteen"; break;
                    case 6: strFor10to19 = "sixteen"; break;
                    case 7: strFor10to19 = "seventeen"; break;
                    case 8: strFor10to19 = "eightteen"; break;
                    case 9: strFor10to19 = "nineteen"; break;
                }
                jsConsole.writeLine(parsedInput + " --> " + strForHunderds + " and " + strFor10to19);
            }
            else if (numForTens === 0) {
                switch (numForOnes) {
                    case 0: strForOnes = "."; break;
                    case 1: strForOnes = "one"; break;
                    case 2: strForOnes = "two"; break;
                    case 3: strForOnes = "three"; break;
                    case 4: strForOnes = "four"; break;
                    case 5: strForOnes = "five"; break;
                    case 6: strForOnes = "six"; break;
                    case 7: strForOnes = "seven"; break;
                    case 8: strForOnes = "eight"; break;
                    case 9: strForOnes = "nine"; break;
                }
                jsConsole.writeLine(parsedInput + " --> " + strForHunderds + " and " + strForOnes);
            }
        }
    }
};