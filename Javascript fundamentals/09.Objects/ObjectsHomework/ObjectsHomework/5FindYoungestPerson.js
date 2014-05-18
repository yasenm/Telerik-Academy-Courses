jsConsole.writeLine("Write a function that finds the youngest person in a given array of persons and prints his/hers full name");
jsConsole.writeLine("Each person have properties firstname, lastname and age.");
jsConsole.writeLine("Check console for results also F12");

function Person(fname, lname, ageSet) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = ageSet;

    this.printPerson = function () {
        jsConsole.writeLine("Name : " + this.firstName + " " + this.lastName);
    }
};

function findAndPrintYoungest(prsArr) {
    var personIndex = 0;
    var minAge = Number.MAX_VALUE;

    for (var i = 0; i < prsArr.length; i += 1) {
        if (prsArr[i].age < minAge) {
            minAge = prsArr[i].age;
            personIndex = i;
        }
    }

    prsArr[personIndex].printPerson();
};

var personArr = [
    new Person("Mitko", "Mitkov", 29),
    new Person("Ganio", "Ganev", 25),
    new Person("Niki", "Nikev", 22),
    new Person("Pesho", "Peshev", 17),
    new Person("Grozdanka", "Grozdankova", 24),
    new Person("Maya", "Maeva", 23)
];

findAndPrintYoungest(personArr);