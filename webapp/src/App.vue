<template>
  <div id="app">
    <img src="./assets/sao_logo.png">

    <span v-on:click='goToHome'>Home</span>
    <span v-on:click='goToPersons'>Persons</span>
    <span v-on:click='goToStudents'>Students</span>
    <span v-on:click='goToLogin'>Login</span>

    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App',
  methods: {
    goToHome: function(){
      this.$router.push({ path: 'home'})
    },
    goToPersons: function(){
      this.$router.push({ path: 'persons'})
    },
    goToStudents: function(){
      this.$router.push({ path: 'students'})
    },
    goToLogin: function(){
      this.$router.push({ path: 'login'})
    },
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
