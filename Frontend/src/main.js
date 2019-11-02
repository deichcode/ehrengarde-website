import Vue from 'vue';
import { LMap, LTileLayer, LMarker } from 'vue2-leaflet';
import { Icon } from 'leaflet';
import 'normalize.css';
import 'leaflet/dist/leaflet.css';
import { library } from '@fortawesome/fontawesome-svg-core';
import {
  faDirections,
  faCalendarAlt,
  faEnvelope,
  faCaretDown, faCaretUp,
} from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
import moment from 'moment';
import router from './router';
import App from './App.vue';

const markerIcon2 = require('leaflet/dist/images/marker-icon-2x.png');
const markerIcon = require('leaflet/dist/images/marker-icon.png');
const markerShadow = require('leaflet/dist/images/marker-shadow.png');

Vue.config.productionTip = false;

Vue.use(require('vue-moment'));

Vue.component('l-map', LMap);
Vue.component('l-tile-layer', LTileLayer);
Vue.component('l-marker', LMarker);

library.add(faDirections, faCalendarAlt, faEnvelope, faCaretDown, faCaretUp);
Vue.component('font-awesome-icon', FontAwesomeIcon);

const locale = window.navigator.language || window.navigator.userLanguage;
moment.locale(locale);

// eslint-disable-next-line no-underscore-dangle
delete Icon.Default.prototype._getIconUrl;
Icon.Default.mergeOptions({
  iconRetinaUrl: markerIcon2,
  iconUrl: markerIcon,
  shadowUrl: markerShadow,
});

router.beforeEach((to, from, next) => {
  let title = '';
  const defaultName = 'Ehrengarde der Stadt Neuwied e.V.';
  if (to.meta.title) {
    title = `${to.name} – ${defaultName}`;
  } else {
    title = defaultName;
  }
  document.title = title;
  next();
});

new Vue({
  router,
  render: h => h(App),
}).$mount('#app');
