<template>
    <div>
    <h1 class = "testClass">Login</h1>
    <form>
        Username:<br>
        <input type="text" name="userName"><br>
        Password:<br>
        <input type="password" name="password"><br>
        <br><br>
        <input type="submit" value="Submit">
    </form>
    </div> 
</template>

<script>
    export default 
    {
        name: 'Home',
        data () 
        {
            return {}
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
    /* <link href="sharedcssfile.css" rel="stylesheet" type="text/css"> */
</style>
