var instructors = '{"instructors": [{"first": "First Name", "middle": "Middle Inital", "last": "Last Name"}, {"first": "front", "middle": "center", "last": "back"}, {"first": "Example", "middle": "Text", "last": "Here"},]}'

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
        var id = instructors[i].ID;
        var email = instructors[i].email;
        tableRows += "<tr><td>" + id + "</td><td>" + email + "</td></tr>";
    }
    document.getElementById("instructorstable").innerHTML = tableRows ;
}