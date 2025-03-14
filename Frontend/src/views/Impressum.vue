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
    <Headline :level=2 styling="page-title">Impressum</Headline>
    <div class="wrapper">
      <Card class="card">
        <span class="paragraph_sign">§</span>
        <p>
          Ehrengarde der Stadt Neuwied e.V.
          <br/>
          <a href="mailto:info@ehrengarde-neuwied.de">info@ehrengarde-neuwied.de</a>
        </p>
        <p>
          Präsident
          <br/>
          Stefan Kugler
          <br/>
          Elisabethstraße 38
          <br/>
          Neuwied 56564
          <br/>
          <a href="tel:+492631958788">(+49) 2631 958 788</a>
          <br/>
        </p>
        <p>
          Eingetragen beim Amtsgericht Montabaur
          <br/>
          unter Vereinsregister Nr. 11338
        </p>
      </Card>
    </div>
  </div>

</template>

<script>
import Card from '../components/atoms/Card.vue';
import Headline from '../components/atoms/Headline.vue';

export default {
  name: 'Impressum',
  components: { Headline, Card },
};
</script>
