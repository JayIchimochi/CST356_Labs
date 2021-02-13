<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/image.png">
    <Home/>
  </div>
</template>

<script>
import Home from './components/Home.vue'

export default {
  name: 'App',
  components: {
    Home,
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  background-color: lavenderblush;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
