<!--
<template>
    <div>
        <h1 class ="testClass">People Table</h1>
        <table>
            <tr>
                <th>First Name</th>
                <th>Middle Initial</th>
                <th>Last Name</th>
            </tr>
            <tbody>
                <tr v-for="person in persons" :key="person.Id">
                    <td> empty? </td>
                    <td> empty? </td>
                    <td> empty? </td>
                    <td> {{ person.FirstName }} </td>
                    <td> {{ person.MiddleInitial }} </td>
                    <td> {{ person.LastName }} </td>
                </tr>
            </tbody>
        </table>
    </div> 
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Persons',
        
        data () {
            return {
                persons: []
            }
        },

         methods: {
            getPersons: function() {
                let personsApi = process.env.PERSON_API;
                
                Vue.axios.get(personsApi).then(
                    (response) => {
                        console.log(response)
                        this.persons = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },

        mounted()
        {
            this.getPersons();
        }

    }
</script>
-->

<!-- <script>
     export default 
     {
         name: 'Home',
         data () 
         {
             return {}
         }
     }
 </script> -->
<template>
    <div>
        <h2 class='section-heading'>Persons</h2>
        <table>
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Middle Initial</th>
                    <th>Last Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="person in persons" :key="person.Id">
                    <td>{{ person.FirstName }}</td>
                    <td>{{ person.MiddleInitial }}</td>
                    <td>{{ person.LastName }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Persons',
        
        methods: {
            getPersons: function() {
                let personsApi = process.env.PERSON_API;
                Vue.axios.get(personsApi).then(
                    (response) => {
                        console.log(response)
                        this.persons = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },
        mounted() {
            this.getPersons();
        },
        data () {
            return {
                persons: []
            }
        }
    }
</script>




<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
    /* <link href="sharedcssfile.css" rel="stylesheet" type="text/css"> */
    table {
            font-family: arial;
            border-collapse: collapse;
            width: 100%;
        }
    td, th {
        border: 1px solid #dddddd;
        text-align: left;
        padding: 8px;
    }
    tr:nth-child(even) {
        background-color: #dddddd;
    }
</style>
