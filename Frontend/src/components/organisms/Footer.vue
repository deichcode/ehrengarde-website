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
    padding: calc(2 * #{$default-spacer}) calc(2 * #{$default-spacer}) calc(4 * #{$default-spacer});
    flex-shrink: 0;
    text-align: center;
    color: $gray;

    a {
      @include navigation-link;
      margin-left: calc(2 * #{$default-spacer});
      margin-right: calc(2 * #{$default-spacer});
    }

    p {
      margin-top: calc(2 * #{$default-spacer});
      color: inherit;
    }
  }
</style>
