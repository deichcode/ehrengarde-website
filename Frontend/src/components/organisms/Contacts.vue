<style scoped lang="scss">
  .contact-wrapper {
    display: flex;
    justify-content: space-around;
    flex-wrap: wrap;
  }
</style>

<template>
  <div class="contact-wrapper">
    <Contact v-for="(contact, index) in contacts"
             :key="index"
             :image="contact.image"
             :name="contact.name"
             :email="contact.email"
             :position="contact.position"
    />
  </div>
</template>

<script>
import Contact from '../molecules/Contact.vue';

export default {
  name: 'Contacts',
  components: { Contact },
  props: {
    contacts: Array,
  },
};
</script>
