<style scoped lang="scss">
  .paragraph{
    hyphens: auto;
    text-align: justify;
    column-width: 310px;
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
