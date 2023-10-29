<style scoped lang="scss">
  .paragraph{
    hyphens: auto;
    line-height: 1.3;
  }
</style>

<template>
<p class="paragraph">
  <slot></slot></p>
</template>

<script>
export default {
  name: 'Paragraph',
};
</script>
