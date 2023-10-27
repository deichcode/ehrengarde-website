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
        title: 'Crops',
      },
    },
    {
      path: '/prinzenpaare',
      name: 'Prinzenpaare',
      component: () => import('./views/Prinzenpaare.vue'),
      meta: {
        title: 'Prinzenpaare',
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
        title: 'Termine',
      },
    },
    {
      path: '/impressum',
      name: 'Impressum',
      component: () => import('./views/Impressum.vue'),
      meta: {
        title: 'Impressum',
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
    {
      path: '/spuelmobil',
      name: 'Spülmobil',
      component: () => import('./views/Spuelmobil.vue'),
      meta: {
        title: 'Spuelmobil',
      },
    },
  ],
  scrollBehavior() {
    return { x: 0, y: 0 };
  },
});
