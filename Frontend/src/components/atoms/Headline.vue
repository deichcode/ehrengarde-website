<style scoped lang="scss">
  .headline {
    color: $white;
    text-align: center;
    font-weight: normal;
  }
  .site-title {
    font-family: FetteUNZFraktur, serif;
    text-align: center;
    font-size: 2rem;
    color: $white;
    margin-top: 10px;
    margin-bottom: 10px;
  }
  .page-title {
    font-size: 1.5625rem
  }
</style>

<template>
  <component :is="tag"  class="headline" :class="styling">
    <slot></slot>
  </component>
</template>

<script>
export default {
  name: 'Headline',
  props: {
    styling: {
      type: String,
      validator: value => ['site-title', 'page-title', 'topic-header-title', 'card-title'].includes(value),
    },
    align: {
      type: String,
      validator: value => ['center', 'left'].includes(value),
    },
    level: {
      type: Number,
      validator: value => value >= 1 && value <= 6,
    },
  },
  computed: {
    tag() {
      return `h${this.level}`;
    },
  },
};
</script>
