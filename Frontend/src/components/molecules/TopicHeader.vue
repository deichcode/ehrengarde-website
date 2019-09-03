<style scoped lang="scss">
.topic{

    .header{

        .fotocontainer{

            margin-left: -10px;
            margin-right: -10px;
        }

        .foto{
            height: 500px;
            width: 100%;
            object-fit: cover;
        };

        .name{
            margin-top: -85px;
            width: 250px;
            white-space: pre-wrap;
            font-size: 1.85rem;
        };
    };

};
</style>

<template>
<div class="topic">
<div class="header">
    <div class="fotocontainer">
<img class="foto" :src="src" :alt="altText">
    </div>
    <p class="name">{{name}}</p>
</div>
    <p class="beschreibung">{{beschreibung}}</p>
</div>
</template>

<script>
export default {
  name: 'TopicHeader',
  props: {
    src: String,
    name: String,
    beschreibung: String,
  },
  computed: {
    altText() {
      return `${this.name} des Corps`;
    },
  },
};
</script>
