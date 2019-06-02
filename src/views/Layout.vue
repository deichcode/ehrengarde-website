<template>
  <div id="app-layout">
    <Header></Header>
    <Navigation></Navigation>
    <router-view/>
  </div>
</template>

<script>
import Header from '@/components/organisms/Header.vue';
import Navigation from '@/components/organisms/Navigation.vue';

export default {
  name: 'Layout',
  components: {
    Header,
    Navigation,
  },
};
</script>

<style scoped>

</style>
