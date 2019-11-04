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
      name: 'Start',
      component: Home,
    },
    {
      path: '/kontakte',
      name: 'Kontakte',
      component: () => import('./views/Kontakte.vue'),
      meta: {
        title: 'Kontakt',
      },
    },
    {
      path: '/corps',
      name: 'Corps',
      component: () => import('./views/Corps.vue'),
      meta: {
        title: 'Kontakt',
      },
    },
    {
      path: '/hofstaat',
      name: 'Hofstaat',
      component: () => import('./views/Hofstaat.vue'),
      meta: {
        title: 'Kontakt',
      },
    },
    {
      path: '/traumtaenzer',
      name: 'Traumtaenzer',
      component: () => import('./views/Traumtaenzer.vue'),
      meta: {
        title: 'Traumtaenzer',
      },
    },
    {
      path: '/chronik',
      name: 'chronik',
      component: () => import('./views/Chronik.vue'),
      meta: {
        title: 'Chronik',
      },
    },
    {
      path: '/termine',
      name: 'Termine',
      component: () => import('./views/Termine.vue'),
      meta: {
        title: 'Kontakt',
      },
    },
    {
      path: '/impressum',
      name: 'Impressum',
      component: () => import('./views/Impressum.vue'),
      meta: {
        title: 'Kontakt',
      },
    },
    {
      path: '/datenschutz',
      name: 'Datenschutz',
      component: () => import('./views/Datenschutz.vue'),
      meta: {
        title: 'Datenschutz',
      },
    },
  ],
});
