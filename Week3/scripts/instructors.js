var instructors = '{"instructors": [{"first": "First Name", "middle": "Middle Inital", "last": "Last Name"}, {"first": "front", "middle": "center", "last": "back"}, {"first": "Example", "middle": "Text", "last": "Here"}]}'

function getInstructors() {
    return JSON.parse(instructors);
}

function initializeInstructors() {
    var data = getInstructors();
    displayInstructors(data.instructors);
}

function displayInstructors(instructors) {
    var tableRows = "";
    for (i = 0; i < instructors.length; i++) {
        var firstname = instructors[i].first;
        var middlename = instructors[i].middle;
        var lastname = instructors[i].last;
        tableRows += "<tr><td>" + firstname + "</td><td>" + middlename + "</td><td>" + lastname + "</td></tr>" ;
    }
    document.getElementById("instructorstable").innerHTML = tableRows ;
}