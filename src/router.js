import Vue from 'vue';
import Router from 'vue-router';
import Home from './views/Home.vue';

Vue.use(Router);

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home,
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import(/* webpackChunkName: "about" */ './views/About.vue'),
    },
    {
      path: '/kontakte',
      name: 'Kontakte',
      component: () => import('./views/Kontakte.vue'),
    },
    {
      path: '/corps',
      name: 'Corps',
      component: () => import('./views/Corps.vue'),
    },
    {
      path: '/hofstaat',
      name: 'Hofstaat',
      component: () => import('./views/Hofstaat.vue'),
    },
    {
      path: '/termine',
      name: 'Termine',
      component: () => import('./views/Termine.vue'),
    },
  ],
});
