<template>
  <footer>
    <router-link to="/datenschutz">Datenschutz</router-link>
    <router-link to="/impressum">Impressum</router-link>
  </footer>
</template>

<script>
export default {
  name: 'Footer',
};
</script>

<style scoped lang="scss">
  footer {
    background: $white;
    font-size: 0.6rem;
    padding: $default-spacer;
    flex-shrink: 0;
    text-align: center;
    color: $gray;

    a {
      @include navigation-link
    }

    p {
      margin-top: $double-default-spacer;
      color: inherit;
    }
  }
</style>
