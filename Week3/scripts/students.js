var students = '{"students": [{"ID": "123456789", "email": "Something@example.com"}, {"ID": "000000000", "email": "ID@domain.com"}]}'

function getStudents() {
    return JSON.parse(students);
}

function initializeStudents() {
    var data = getStudents();
    displayStudents(data.students);
}

function displayStudents(students) {
    var tableRows = "";
    for (i = 0; i < students.length; i++) {
        var id = students[i].ID;
        var email = students[i].email;
        tableRows += "<tr><td>" + id + "</td><td>" + email + "</td></tr>";
    }
    document.getElementById("studenttable").innerHTML = tableRows ;
}