<style scoped lang="scss">
  $circle-radius: 15px;

  .card {
    color: white;
    padding: 10px 10px 20px;
    text-align: center;
    z-index: 9;
    overflow: hidden;
    position: relative;

    &:before {
      position: absolute;
      bottom: -$circle-radius;
      right: calc(50% - #{$circle-radius});
      padding: $circle-radius;
      border-radius: 100%;
      box-shadow: 0 0 0 1000vw $light-blue;
      content: '';
    }
    .card-content {
      position: relative;
      flex-grow: 1;
      display: flex;
      flex-direction: column;
    }
  }

</style>

<template>
  <div class="card">
    <div class="card-content">
      <slot></slot>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Card',
};
</script>
