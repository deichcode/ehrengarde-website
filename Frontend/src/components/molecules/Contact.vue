<style scoped lang="scss">
  .contact {
    display: flex;
    margin-bottom: 15px;
    color: $white;
    flex: 0 1 280px;
    flex-wrap: wrap;

    .card {
      .card-content {
        padding-bottom: 10px;
      }
    }

    .portrait {
      width: 155px;
      height: 155px;
      border-radius: 50%;
    }


    .position {
      font-size: 0.857rem;
      margin: 10px 0 0 0;
      padding-top: 10px;
    }

    .name {
      font-size: 1.571rem;
      margin: 0 0 10px 0;
    }

    .email {
      font-size: 0.6rem;
      margin: 5px 0 0 0;

      a {
        color: inherit;
        text-decoration: none;
      }
    }
  }

  /*@media (max-width: 400px) {*/
  .contact {
    flex-direction: column;
  }

  /*}*/
</style>

<template>
  <Card class="contact">
    <img class="portrait" :src="image" :alt="altText">
    <p class="position separation_border_top_thin">{{position}}</p>
    <p class="name">{{name}}</p>
    <a :href="mailtoLink"><font-awesome-icon icon="envelope" :style="{ color: 'white'}"/></a>
    <p class="email"><a :href="mailtoLink">{{email}}</a></p>
  </Card>
</template>

<script>
import Card from '../atoms/Card.vue';

export default {
  name: 'Contact',
  components: { Card },
  props: {
    image: String,
    name: String,
    position: String,
    email: String,
  },
  computed: {
    altText() {
      return `Portrait von ${this.name}, ${this.position}`;
    },
    mailtoLink() {
      return `mailto:${this.email}`;
    },
  },
};
</script>
