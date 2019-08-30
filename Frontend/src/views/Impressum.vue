<style scoped lang="scss">
  .paragraph_sign {
    font-size: 2.667rem;
  }

  .card {
    max-width: 400px;
  }

  .wrapper {
    display: flex;
    justify-content: space-around;
  }
</style>

<template>
  <div class="content">
    <h2 class="title">Impressum</h2>
    <div class="wrapper">
      <Card class="card">
        <span class="paragraph_sign">§</span>
        <p>
          Ehrengarde der Stadt Neuwied e.V.
          <br/>
          <a href="mailto:info@ehrengarde-neuwied.de">info@ehrengarde-neuwied.de</a>
        </p>
        <p>
          Markus Schröder
          <br/>
          Hochstraße 128
          <br/>
          56566 Neuwied
          <br/>
          <a href="tel:+492631948139">(0 26 31) 49 81 39</a>
          <br/>
        </p>
        <p>
          Eingetragen beim Amtsgericht
          <br/>
          unter Vereinsregister Nr. 11338
        </p>
      </Card>
    </div>
  </div>

</template>

<script>
import Card from '../components/atoms/Card.vue';

export default {
  name: 'Impressum',
  components: { Card },
};
</script>
