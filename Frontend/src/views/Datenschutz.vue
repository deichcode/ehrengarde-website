<style scoped lang="scss">
  .card {
    max-width: 600px;
  }

  .wrapper {
    display: flex;
    justify-content: space-around;
  }
</style>

<template>
  <div class="content">
    <Headline :level=2 styling="page-title">Datenschutz</Headline>
    <div class="wrapper">
      <Card class="card">
        <p>
          Platzhalter für Datenschutzerklärung
        </p>
      </Card>
    </div>
  </div>

</template>

<script>
import Card from '../components/atoms/Card.vue';
import Headline from '../components/atoms/Headline.vue';

export default {
  name: 'Datenschutz',
  components: { Headline, Card },
};
</script>
