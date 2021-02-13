<template>
    <div>
        <h1>Student Table</h1>

        <table id="studenttable" border="1px solid black">
            
        </table>
    </div>
</template>

<script>
export default {
  name: 'Student',
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