<style scoped lang="scss">
    .imagecontainer{
        margin-left: -10px;
        margin-right: -10px;

        .foto{
            width: 100%;
        }

    }
</style>

<template>
    <div class="freizeit">
        <div class="imagecontainer">
        <img class="foto" :src="src" alt="Platzhalter für Foto">
        </div>
        <p class="beschreibung">{{beschreibung}}</p>
    </div>
</template>

<script>
export default {
  name: 'Activity',
  props: {
    src: String,
    beschreibung: String,
  },
};
</script>
