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
      padding: 0 5px 5px;
      margin-bottom: 10px;
      position: relative;
      font-family: superclarendon, serif;
      font-weight: 400;
      font-style: normal;
      text-decoration: none;
      color: $gray;
      font-size: 0.8rem;

      &:after {
        position: absolute;
        left: 50%;
        content: '';
        height: 1px;
        background: $gray;
        transition: all 0.2s linear;
        width: 0;
        bottom: 0px;
      }

      &.router-link-exact-active:after,
      &:hover:after {
        width: 100%;
        left: 0px;
      }
    }
  }
</style>
