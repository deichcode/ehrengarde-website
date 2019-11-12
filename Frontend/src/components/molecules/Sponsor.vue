<style scoped lang="scss">
    .card {
        display: flex;
        margin-bottom: 15px;
        color: $white;
        flex: 0 1 280px;
        flex-wrap: wrap;

        .logo {
            max-width: 100%;
            height: 155px;
        }
        .name {
            font-size: 1.571rem;
            margin: 0 0 10px 0;
        }

        .link {
            font-size: 0.6rem;
            margin: 5px 0 10px 0;

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
        <img class="logo" :src="image" :alt="altText" v-if="image">
        <p :class="{
        'position':true,
        'position--with-image': image,
        'separation_border_top_thin': image
    }">
        </p>
        <p class="name">{{name}}</p>
        <a :href="websitetoLink">
            <font-awesome-icon icon="link" :style="{ color: 'white'}"/>
        </a>
        <p class="link"><a :href="websitetoLink">{{link}}</a></p>
    </Card>
</template>

<script>
import Card from '../atoms/Card.vue';

export default {
  name: 'Sponsor',
  components: { Card },
  props: {
    image: String,
    name: String,
    link: String,
  },
  computed: {
    altText() {
      return `Logo von ${this.name}`;
    },
    websitetoLink() {
      return `${this.link}`;
    },
  },
};
</script>
