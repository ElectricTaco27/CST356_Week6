<template>
    <div>
        <h1 class ="testClass">Student Table</h1>
        <table>
            <thead>
                <tr>
                    <th>Student ID</th>
                    <th>Email Address</th>
                </tr>
            </thead>
            <tbody>
                <td> -1 </td>
                <td> test </td>
                <tr v-for="student in students" :key="student.Id">
                    <td> {{ student.Id }} </td>
                    <td> {{ student.Email }} </td>
                </tr>
            </tbody>
        </table>
    </div> 
</template>

<script>
    import Vue from 'vue';

    export default 
    {
        name: 'Students',
        data() 
        {
            return 
            {
                students: []
            }
        },
        methods: 
        {
            getStudents: function()
            {
                let studentsApi = process.env.STUDENT_API;

                Vue.axios.get(studentsApi).then(
                    (response) => {
                        console.log(response)
                        this.students = response.data
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            }
        },

        mounted() 
        {
            this.getStudents();
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
    tr:nth-child(even){
        background-color: #dddddd;
    }
</style>
