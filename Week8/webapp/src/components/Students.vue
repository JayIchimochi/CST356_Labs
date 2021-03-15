<template>
    <div>
        <div v-if='operation == "list"'>
            <h2 class='section-heading'>Students</h2>
            <table>
                <thead>
                    <tr>
                        <th>Student ID</th>
                        <th>Email Address</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="student in students" :key="student.studentId">
                        <td>{{ student.studentId }}</td>
                        <td>{{ student.email }}</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Students',
        
        data () {
            return {
                students: [],
                operation: 'list',
                studentId: undefined,
                email: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },
        methods: {
            getStudents: function() {
                let url = `http://${this.apiServer}/api/student`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
        },
        mounted() {
            this.getStudents();
            this.operation = 'list';
        }
    }
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