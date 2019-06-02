<template>
  <footer>
    <router-link to="/impressum">Impressum</router-link>
    _
    Ehrengarde der Stadt Neuwied e.V. | Geschäftsführer: Marcel Thran |
    Eingetragen beim Amtsgericht Montabaur unter Vereinsregister Nr. 11338
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
    font-size: 0.4rem;
    padding: $outer-space;
    flex-shrink: 0;

    a {
      @include navigation-link
    }
  }
</style>
