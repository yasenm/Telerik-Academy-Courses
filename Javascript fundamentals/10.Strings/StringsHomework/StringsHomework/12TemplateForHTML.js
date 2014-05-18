//jsConsole.writeLine("Write a function that creates a HTML UL using a template for every HTML LI.");
//jsConsole.writeLine("The source of the list should an array of elements. Replace all placeholders");
//jsConsole.writeLine("marked with –{…}–   with the value of the corresponding property of the object.");
//jsConsole.writeLine("Check console for results also F12 !!!!!!!!!!!!! WORKS PERFECTLY IN FIREFOX!");

function Person(name, age) {
    this.name = name;
    this.age = age;
    this.listView = '';
}

function addListItems(people, tmpl, list) {
    for (var i = 0; i < people.length; i += 1) {
        list += '<li>' + parseAndReplace(tmpl, people[i]) + '</li>';
    }
    list += '</ul>';
    return list;
}

function parseAndReplace(tmpl, person) {
    for (var property in person) {
        var placeholder = '-{' + property + '}-';
        tmpl = tmpl.replace(placeholder, person[property]);
    }
    console.log(tmpl);
    return tmpl;
}

var template = '';

function getTemplate() {
    template = document.getElementById('list-item').innerHTML;
}

var people = [
    new Person('Ganio', 25),
    new Person('Ivan', 23),
    new Person('Pesho', 26),
    new Person('Gosho', 18),
    new Person('Mariika', 25),
    new Person('Grozdanka', 24)
];

var peopleList = '<ul>';

function addListItemsClick() {
    getTemplate();
    var newTmpl = addListItems(people, template, peopleList);
    document.getElementById('list-item').innerHTML = newTmpl;
}