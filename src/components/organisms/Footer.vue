<template>
  <footer>
    <router-link to="/impressum">Impressum</router-link>
    <p>_</p>
    <p>Ehrengarde&nbsp;der&nbsp;Stadt&nbsp;Neuwied&nbsp;e.V.
      Geschäftsführer:&nbsp;Marcel&nbsp;Thran
      Eingetragen&nbsp;beim&nbsp;Amtsgericht unter&nbsp;Vereinsregister&nbsp;Nr.&nbsp;11338
    </p>
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
    padding: $outer-space;
    flex-shrink: 0;
    text-align: center;
    color: $gray;

    a {
      @include navigation-link
    }

    p {
      color: inherit;
    }
  }
</style>
