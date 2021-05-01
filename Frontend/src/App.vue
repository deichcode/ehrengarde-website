<style lang="scss">
  #app {
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    display: flex;
    flex-direction: column;
    min-height: 100vh;
  }
  #wrapper {
    flex: 1 0 auto;
  }
</style>

<template>
  <div id="app">
    <div id="wrapper">
      <Header></Header>
      <Navigation></Navigation>
      <main>
        <router-view></router-view>
      </main>
    </div>
    <Footer></Footer>
  </div>
</template>

<script>
import Navigation from '@/components/organisms/Navigation.vue';
import Header from '@/components/organisms/Header.vue';
import Footer from './components/organisms/Footer.vue';

export default {
  name: 'app',
  components: {
    Footer,
    Header,
    Navigation,
  },
};
</script>
