<template>
  <header>
    <div class="wappen">
      <Wappen corps="aktive"></Wappen>
      <Wappen corps="piccolos"></Wappen>
      <Wappen corps="reservisten"></Wappen>
      <Wappen corps="eos"></Wappen>
    </div>
    <router-link to="/"><h1>Ehrengarde der Stadt Neuwied&nbsp;e.V.</h1></router-link>
  </header>
</template>

<script>
import Wappen from '../atoms/Wappen.vue';

export default {
  components: { Wappen },
};
</script>

<style scoped lang="scss">
  header {
    background: $light-blue;
    padding: $default-spacer;
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

  h1 {
    font-family: FetteUNZFraktur, serif;
    text-align: center;
    font-size: 2rem;
    color: $white;
    margin-top: 10px;
    margin-bottom: 10px;
  }
</style>
