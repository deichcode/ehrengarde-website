<template>
  <nav>
    <router-link to="/">Start</router-link>
    |
    <router-link to="/kontakte">Kontakte</router-link>
    |
    <router-link to="/corps">Corps</router-link>
    |
    <router-link to="/hofstaat">Hofstaat</router-link>
    |
    <router-link to="/termine">Termine</router-link>
  </nav>
</template>

<script>
export default {
  name: 'Navigation',
};
</script>

<style scoped lang="scss">
  nav {
    position: sticky;
    top: 0;
    background-color: $white;
    display: flex;
    justify-content: space-evenly;
    padding: $outer-space;
    padding-bottom: 0;
    flex-wrap: wrap;

    a {
      @include navigation-link;
    }
  }
</style>
