<style scoped lang="scss">
  header {
    background: $light-blue;
    padding: $default-spacer;
    box-shadow: 0px 3px 6px $shadow;
    position: relative;
    z-index: 30;
  }

  .wappen {
    max-width: 700px;
    margin: 0 auto;
    display: flex;
    justify-content: space-between;
    width: calc(100% - 40px);
  }

  a {
    text-decoration: none;
  }
</style>

<template>
  <header>
    <div class="wappen">
      <Wappen corps="aktive"></Wappen>
      <Wappen corps="piccolos"></Wappen>
      <Wappen corps="reservisten"></Wappen>
      <Wappen corps="eos"></Wappen>
    </div>
    <router-link to="/">
      <Headline :level=1 styling="site-title">Ehrengarde der Stadt Neuwied&nbsp;e.V.</Headline>
    </router-link>
  </header>
</template>

<script>
import Wappen from '../atoms/Wappen.vue';
import Headline from '../atoms/Headline.vue';

export default {
  components: { Headline, Wappen },
};
</script>
