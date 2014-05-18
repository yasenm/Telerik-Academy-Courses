jsConsole.writeLine("------- Exercise results are also in console.log check F12 to see! -------");
jsConsole.writeLine("");

// Exercise #1
// Array literals
jsConsole.writeLine("------- Exercise #1 -------");
jsConsole.writeLine("");

var sampleArray = ["string", 67, 5.4546, true, false, {}];

jsConsole.writeLine("------- Array literals -------");
jsConsole.writeLine(sampleArray);
jsConsole.writeLine("------- Array literals single element of array -------");
jsConsole.writeLine(sampleArray[0]);
jsConsole.writeLine(sampleArray[2]);
jsConsole.writeLine(sampleArray[4]);
jsConsole.writeLine("");

console.log("------- Array literals -------");
console.log(sampleArray);
console.log("------- Array literals single element of array -------");
console.log(sampleArray[0]);
console.log(sampleArray[2]);
console.log(sampleArray[4]);
console.log("");

// Boolean literals
var booleanLiteral = true;

jsConsole.writeLine("------- Boolean literals -------");
jsConsole.writeLine(booleanLiteral);
jsConsole.writeLine(!booleanLiteral);
jsConsole.writeLine("");

console.log("------- Boolean literals -------");
console.log(booleanLiteral);
console.log(!booleanLiteral);
console.log("");

// Integers
var firstInt = 5;
var secondInt = 10;
var thirdInt = 38468;

jsConsole.writeLine("------- Integers -------");
jsConsole.writeLine(firstInt);
jsConsole.writeLine(secondInt);
jsConsole.writeLine(thirdInt);
jsConsole.writeLine(thirdInt + firstInt);
jsConsole.writeLine(thirdInt + secondInt);
jsConsole.writeLine(firstInt + secondInt);
jsConsole.writeLine("");

console.log("------- Integers -------");
console.log(firstInt);
console.log(secondInt);
console.log(thirdInt);
console.log(thirdInt + firstInt);
console.log(thirdInt + secondInt);
console.log(firstInt + secondInt);
console.log("");

// Floating point literals
var firstFloat = 3.14;
var secondFloat = 4563.476587890;
var thirdFloat = -.4763587;

jsConsole.writeLine("------- Floating point literals -------");
jsConsole.writeLine(firstFloat);
jsConsole.writeLine(secondFloat);
jsConsole.writeLine(thirdFloat);
jsConsole.writeLine(thirdFloat + firstFloat);
jsConsole.writeLine("");

console.log("------- Floating point literals -------");
console.log(firstFloat);
console.log(secondFloat);
console.log(thirdFloat);
console.log(thirdFloat + firstFloat);
console.log("");

// String literals
var firstName = "Ganio";
var secondName = "Ganev";
var thirdName = "Ganistiq";

jsConsole.writeLine("------- String literals -------");
jsConsole.writeLine(firstName);
jsConsole.writeLine(secondName);
jsConsole.writeLine(thirdName);
jsConsole.writeLine(firstName + " " + secondName + " " + thirdName);
jsConsole.writeLine(firstName + " new line coming.....\n " + secondName + " " + thirdName + " -----> new line is working in console.log check console");
jsConsole.writeLine("");

console.log("------- String literals -------");
console.log(firstName);
console.log(secondName);
console.log(thirdName);
console.log(firstName + " " + secondName + " " + thirdName);
console.log(firstName + " new line coming.....\n " + secondName + " " + thirdName);
console.log("");

// Object literals
var person = {
    fisrtName: 'Ganio',
    lastName: 'Ganev',
    nickName: 'Ganistiq',
    age: 23
}

jsConsole.writeLine("------- Object literals -------");
jsConsole.writeLine("person first name: " + person.fisrtName);
jsConsole.writeLine("person last name: " + person.lastName);
jsConsole.writeLine("person nickname: " + person.nickName);
jsConsole.writeLine("person age: " + person.age);
jsConsole.writeLine("person full info: " + person.fisrtName + " " + person.lastName + " " + person.nickName + ", age : " + person.age);
jsConsole.writeLine("");

console.log("------- Object literals -------");
console.log("person first name: " + person.fisrtName);
console.log("person last name: " + person.lastName);
console.log("person nickname: " + person.nickName);
console.log("person age: " + person.age);
console.log("person full info: " + person.fisrtName + " " + person.lastName + " " + person.nickName + ", age : " + person.age);
console.log("");

// Exercise #2
jsConsole.writeLine("------- Exercise #2 -------");
jsConsole.writeLine("");
console.log("------- Exercise #2 -------");
console.log("");

var text = '"How are you doin?", Joey said';

jsConsole.writeLine("-> Without escaped quoets single quote marks for string :");
jsConsole.writeLine(text);

console.log("-> Without escaped quoets single quote marks for string :");
console.log(text);

var textEscaped = "\"How are you doin?\", Joey said";

jsConsole.writeLine("-> With escaped quoets double quote marks for string :");
jsConsole.writeLine(textEscaped);
jsConsole.writeLine("");

console.log("-> With escaped quoets double quote marks for string :");
console.log(textEscaped);
console.log("");

// Exercise #3
jsConsole.writeLine("------- Exercise #3 -------");
jsConsole.writeLine("");
console.log("------- Exercise #3 -------");
console.log("");

jsConsole.writeLine("type of array : " + typeof sampleArray);
jsConsole.writeLine("type of boolean literal : " + typeof booleanLiteral);
jsConsole.writeLine("type of integer : " + typeof firstInt);
jsConsole.writeLine("type of integer : " + typeof secondInt);
jsConsole.writeLine("type of integer : " + typeof thirdInt);
jsConsole.writeLine("type of floating point : " + typeof firstFloat);
jsConsole.writeLine("type of floating point : " + typeof secondFloat);
jsConsole.writeLine("type of floating point : " + typeof thirdFloat);
jsConsole.writeLine("type of string : " + typeof firstName);
jsConsole.writeLine("type of string : " + typeof secondName);
jsConsole.writeLine("type of string : " + typeof thirdName);
jsConsole.writeLine("type of object (person) : " + typeof person);
jsConsole.writeLine("");

console.log("type of array : " + typeof sampleArray);
console.log("type of boolean literal : " + typeof booleanLiteral);
console.log("type of integer : " + typeof firstInt);
console.log("type of integer : " + typeof secondInt);
console.log("type of integer : " + typeof thirdInt);
console.log("type of floating point : " + typeof firstFloat);
console.log("type of floating point : " + typeof secondFloat);
console.log("type of floating point : " + typeof thirdFloat);
console.log("type of string : " + typeof firstName);
console.log("type of string : " + typeof secondName);
console.log("type of string : " + typeof thirdName);
console.log("type of object (person) : " + typeof person);
console.log("");

// Exercise #4
jsConsole.writeLine("------- Exercise #4 -------");
jsConsole.writeLine("");
console.log("------- Exercise #4 -------");
console.log("");

var nullVar = null;
var undefVar = undefined;

jsConsole.writeLine("type of variable = null : " + typeof nullVar);
jsConsole.writeLine("type of variable = undefined : " + typeof undefVar);
jsConsole.writeLine("");

console.log("type of variable = null : " + typeof nullVar);
console.log("type of variable = undefined : " + typeof undefVar);
console.log("");