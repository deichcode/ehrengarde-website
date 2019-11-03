<style scoped lang="scss">
    .imagecontainer{
        margin-left: -10px;
        margin-right: -10px;

        .photo{
        width: 100%;
          }

    }
</style>

<template>
        <div class="imagecontainer">
            <img class="photo" :src="src" alt="Platzhalter für Foto">
        </div>
</template>

<script>
export default {
  name: 'Picture',
  props: {
    src: String,
  },
};
</script>
