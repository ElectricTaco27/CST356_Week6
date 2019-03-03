import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Students from '@/components/Students'
import Person from '@/components/Person'
import Login from '@/components/Login'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/home',
      name: 'Home',
      component: Home
    },
    {
      path: '/students',
      name: 'Students',
      component: Students
    },
    {
      path: '/persons',
      name: 'persons',
      component: Person
    },
    {
      path: '/login',
      name: 'Login',
      component: Login
    },
  ]
})
