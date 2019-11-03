<style scoped lang="scss">
  .topic-header {
    margin-left: -10px;
    margin-right: -10px;
    .container {
      position: relative;

      .photo {
        height: 500px;
        width: 100%;
        object-fit: cover;
      }

      .title-background {
        display: flex;
        flex-direction: column-reverse;
        position: absolute;
        bottom: 2px;
        width: 100%;
        height: 100px;
        background: linear-gradient(0, black, rgba(0, 0, 0, 0));

        .title {
          font-size: 2.1875rem;
          margin: 0 10px 5px;
          width: 300px;
        }
      }
    }
  }
</style>

<template>
  <div class="topic-header">
    <div class="container">
      <img class="photo" :src="src" :alt="altText">
      <div class="title-background">
        <p class="title">{{title}}</p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'TopicHeader',
  props: {
    src: String,
    title: String,
  },
  computed: {
    altText() {
      return `${this.title} des Corps`;
    },
  },
};
</script>
