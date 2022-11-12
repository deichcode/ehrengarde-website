<style scoped lang="scss">
  .paragraph{
    hyphens: auto;
  }
</style>

<template>
<p class="paragraph">
  <slot></slot>
</p>
</template>

<script>
export default {
  name: 'Paragraph',
};
</script>
