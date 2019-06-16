<style scoped lang="scss">
  .contact {
    height: 85px;
    background: $light-blue;
    display: flex;
    margin-bottom: 15px;
    padding: 5px;
    flex: 0 0 300px;
    color: $white;
    flex-basis: calc(100% - 10px);

    .portrait {
      width: 85px;
      height: 85px;
      border-radius: 50%;
    }

    .infos {
      .position {
        font-size: 0.7rem;
        margin: 15px 0 0 0;
      }

      .name {
        font-size: 1rem;
        margin: 8px 0 0 0;
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
  }
</style>

<template>
  <div class="contact">
    <img class="portrait" :src="src" :alt="altText">
    <div class="infos">
      <p class="position">{{position}}</p>
      <p class="name">{{name}}</p>
      <p class="email"><a :href="mailtoLink">{{email}}</a></p>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Contact',
  props: {
    src: String,
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
