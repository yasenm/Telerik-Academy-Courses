jsConsole.writeLine("Write a script that parses an URL address given in the format:");
jsConsole.writeLine("[protocol]://[server]/[resource]");
jsConsole.writeLine("and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.");
jsConsole.writeLine("For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:");
jsConsole.writeLine("{protocol: \"http\",");
jsConsole.writeLine("server: \"www.devbg.org\", ");
jsConsole.writeLine("resource: \"/forum/index.php\"}");
jsConsole.writeLine("Check console for results also F12");


function extractURL() {
    var addressObject = [
        {
            protocol: window.location.protocol,
            server: window.location.host,
            resource: window.location.pathname
        }
    ]

    jsConsole.writeLine(addressObject[0].protocol);
    jsConsole.writeLine(addressObject[0].server);
    jsConsole.writeLine(addressObject[0].resource);
};