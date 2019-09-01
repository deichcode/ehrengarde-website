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
    <h2 class="title">Datenschutz</h2>
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

export default {
  name: 'Datenschutz',
  components: { Card },
};
</script>
