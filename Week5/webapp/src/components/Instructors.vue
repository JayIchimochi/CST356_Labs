<template>
    <div>
        <h1>Instructor Table</h1>

        <table id="instructorstable" border="1px solid black">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Middle Inital</th>
                    <th>Last Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="instructor in instructors" v-bind:key="instructor">
                    <td>{{ instructor.first }}</td>
                    <td>{{ instructor.middle }}</td>
                    <td>{{ instructor.last }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
 export default {
        name: 'InstructorsTable',
        mounted() {
            this.instructors = getInstructors();
        },
        data () {
            return {
                instructors: []
            }
        }
    }
    function getInstructors() {
        return JSON.parse(instructors);
    }
    var instructors = '[{"first": "First Name", "middle": "Middle Inital", "last": "Last Name"}, {"first": "front", "middle": "center", "last": "back"}, {"first": "Example", "middle": "Text", "last": "Here"}]';
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
p {
    font-family: 'Courier New', Courier, monospace;
    background-color: grey;
}

.header-style {
    color: green;
}

.tableheading {
    font-size: large;
    color: greenyellow;
}
</style>