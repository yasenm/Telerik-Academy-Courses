jsConsole.writeLine("Write a function that groups an array of persons by age, first or last name. The function must return");
jsConsole.writeLine("an associative array, with keys - the groups, and values -arrays with persons in this groups");
jsConsole.writeLine("  -->  Use function overloading (i.e. just one function)");
jsConsole.writeLine("Check console for results also F12");

function Person(fname, lname, ageSet) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = ageSet;

    this.printPerson = function () {
        jsConsole.writeLine("Name : " + this.firstName + " " + this.lastName + " age : " + this.age);
        console.log("Name : " + this.firstName + " " + this.lastName + " age : " + this.age);
    }
};

function printResultArrays(resultArr) {
    for (var i in resultArr) {
        jsConsole.writeLine("Grouped by : " + i);
        console.log("Grouped by : " + i);

        for (var index = 0; index < resultArr[i].length; index++) {
            resultArr[i][index].printPerson();
        }
    }
};

function group(persons, age) {
    var resultArray = {};
        person = 0;

    switch (arguments[1]) {
        case 'age':
            for (person in persons) {
                var ageIndex = persons[person].age;

                if (!resultArray[ageIndex]) {
                    resultArray[ageIndex] = [];
                }

                resultArray['' + ageIndex].push(persons[person]);
            }
            break;
        case 'firstname':
            for (person in persons) {
                var firtsname = persons[person].firstName;

                if (!resultArray[firtsname]) {
                    resultArray[firtsname] = [];
                }

                resultArray['' + firtsname].push(persons[person]);
            }
            break;
        case 'lastname':
            for (person in persons) {
                var lastname = persons[person].lastName;

                if (!resultArray[lastname]) {
                    resultArray[lastname] = [];
                }

                resultArray['' + lastname].push(persons[person]);
            }
            break;
        }

    return resultArray;
};

var persons = {
    person1: new Person('Ganio', 'Ganev', 17),
    person2: new Person('ivan', 'ivanov', 19),
    person3: new Person('pesho', 'peshev', 13),
    person4: new Person('Ganio', 'Ganev', 17)
};

var groupedByAge = group(persons, 'age');
var groupedByFirstName = group(persons, 'firstname');
var groupedByLastName = group(persons, 'lastname');

jsConsole.writeLine("");
console.log("");
jsConsole.writeLine("Grouped by age: ");
console.log("Grouped by age: ");
printResultArrays(groupedByAge);

jsConsole.writeLine("");
console.log("");
jsConsole.writeLine("Grouped by first name: ");
console.log("Grouped by first name: ");
printResultArrays(groupedByFirstName);

jsConsole.writeLine("");
console.log("");
jsConsole.writeLine("Grouped by last name: ");
console.log("Grouped by last name: ");
printResultArrays(groupedByLastName);
