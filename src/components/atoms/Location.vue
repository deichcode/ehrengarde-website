<style scoped lang="scss">
  .map_wrapper {
    padding-top: 10px;
  }
</style>

<style>
  /*noinspection CssUnusedSymbol*/
  .leaflet-control-attribution {
    display: none;
  }
</style>

<template>
  <div @click="tabZoom" style="height: 100%;">
    <l-map
      :id="id"
      :zoom="zoom"
      :center="center"
      :options="{
        zoomControl: false,
        dragging: !isMobile,
        scrollWheelZoom: !isMobile,
        doubleClickZoom: !isMobile,
        touchZoom: !isMobile
      }"
    >
      <l-tile-layer :url="url"></l-tile-layer>
      <l-marker :lat-lng="center" ></l-marker>
    </l-map>
  </div>
</template>

<script>
import L from 'leaflet';
import { OpenStreetMapProvider } from 'leaflet-geosearch';

const provider = new OpenStreetMapProvider();


export default {
  name: 'Location',
  props: {
    location: String,
  },
  data() {
    return {
      id: Math.random().toString(36).substring(7),
      baseZoom: 17,
      zoomOffset: 0,
      center: [50.4603186, 7.448272],
      url: 'https://{s}.basemaps.cartocdn.com/rastertiles/voyager/{z}/{x}/{y}{r}.png',
      bounds: null,
      isMobile: L.Browser.mobile,
    };
  },
  computed: {
    zoom() {
      return this.baseZoom - this.zoomOffset;
    },
  },
  methods: {
    tabZoom() {
      this.zoomOffset = (this.zoomOffset + 2) % 8;
    },
    async getGeolocation() {
      const result = await provider.search({ query: this.location });
      return [result[0].y, result[0].x];
    },
  },
  async mounted() {
    const center = await this.getGeolocation();
    this.center = center;
  },
};

</script>
