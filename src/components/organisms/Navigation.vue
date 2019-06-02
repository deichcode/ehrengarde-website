<template>
  <nav>
    <router-link to="/kontakte">Kontakte</router-link>
    |
    <router-link to="/corps">Crops</router-link>
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
    background-color: $white;
    display: flex;
    justify-content: space-around;
    padding: 5px $outer-space;
    a {
      font-family: superclarendon, serif;
      font-weight: 400;
      font-style: normal;
      text-decoration: none;
      color: $gray;
      font-size: 0.8rem;
    }
  }
</style>
