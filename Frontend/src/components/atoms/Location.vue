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
  <div v-if="locationFound" @click="tabZoom" style="height: 100%;">
    <l-map
      ref="locationMap"
      :zoom="baseZoom"
      :center="center"
      :options="{
                    zoomControl: false,
                    dragging: !isMobile,
                    touchZoom: !isMobile,
                    doubleClickZoom: !isMobile,
                    scrollWheelZoom: !isMobile,
                    boxZoom: !isMobile,
                    keyboard: !isMobile,
                    tap: !isMobile,
                }"
    >
      <l-tile-layer :url="url"></l-tile-layer>
      <l-marker :lat-lng="center"></l-marker>
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
      locationFound: true,
    };
  },
  methods: {
    tabZoom() {
      if (this.isMobile) {
        this.zoomOffset = (this.zoomOffset + 2) % 8;
        this.$nextTick(() => {
          this.$refs.locationMap.mapObject.setZoom(this.baseZoom - this.zoomOffset);
        });
      }
    },
    async getGeolocation() {
      const result = await provider.search({ query: this.location });
      if (result.length > 0) {
        return [result[0].y, result[0].x];
      }
      this.$nextTick(() => {
        this.locationFound = false;
      });
      return null;
    },
  },
  async mounted() {
    this.center = await this.getGeolocation();
  },
};

</script>
