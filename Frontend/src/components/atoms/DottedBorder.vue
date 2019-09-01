<style scoped lang="scss">
  .dotted_border {
    width: 100%;
    height: 0;
    border-width: 0 0 4px 0;
    border-style: solid;
    border-image-source: url(../../assets/graphics/dotted-border.svg);
    border-image-repeat: round;
    border-image-slice: 33%;
    margin-top: 10px;
  }
</style>


<template>
  <div class="dotted_border"></div>
</template>

<script>
export default {
  name: 'DottedBorder',
};
</script>
