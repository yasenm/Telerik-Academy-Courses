jsConsole.writeLine("Write a script that finds the lexicographically smallest and largest");
jsConsole.writeLine("property in document, window and navigator objects.");
jsConsole.writeLine("Check console for results also F12");

//defining the funcions findSmallest() and findBiggest() fpr the properties in the document
findSmallest(window);
findBiggest(window);
findSmallest(navigator);
findBiggest(navigator);
findSmallest(document);
findBiggest(document);

//finds lexicographically the smallest property
function findSmallest(object) {
    //since we give smallest = "zzz"; it can't be actualy that so it actualy becomes the next
    var smallest = 'zzz';

    //property compared to the last one in the accending order which means it makes
    for (var property in object) {
        //a new start and thats the first and smallest of the next order.
        if (property < smallest) {
            smallest = property;
        }
    }

    jsConsole.writeLine("The lexicographically smallest property in " + object + " is " + smallest);
    jsConsole.writeLine("");
    console.log("The lexicographically smallest property in " + object + " is " + smallest);
    console.log("");
};

//finds lexicographically the biggest property
function findBiggest(object) {
    //same logic as for smallest iun reverse
    var biggest = 'aaa';

    for (var property in object) {
        if (property > biggest) {
            biggest = property;
        }
    }

    jsConsole.writeLine("The lexicographically smallest property in " + object + " is " + biggest);
    jsConsole.writeLine("");
    console.log("The lexicographically smallest property in " + object + " is " + biggest);
    console.log("");
};