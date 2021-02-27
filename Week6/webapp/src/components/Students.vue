<template>
    <div>
        <h1>Student Table</h1>

        <table id="studenttable" border="1px solid black">
            <thead>
                <tr>
                    <th>Student ID</th>
                    <th>Student E-mail</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td>{{ student.ID }}</td>
                    <td>{{ student.email }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
export default {
        name: 'StudentsTable',
        mounted() {
            this.students = getStudents();
        },
        data () {
            return {
                students: []
            }
        }
    }
    function getStudents() {
        return JSON.parse(students);
    }
    var students = '[{"ID": "123456789", "email": "Something@example.com"}, {"ID": "000000000", "email": "ID@domain.com"}]'
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
p {
    font-family: 'Courier New', Courier, monospace;
    background-color: grey;
}

#mainheader {
    font-size: larger;
    color: lawngreen;
}

.header-style {
    color: green;
}

.tableheading {
    font-size: large;
    color: greenyellow;
}
</style>