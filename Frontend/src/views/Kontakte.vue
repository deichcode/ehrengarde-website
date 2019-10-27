<style scoped lang="scss">
</style>

<template>
  <div class="content">
    <Headline :level=2 styling="page-title">Kontakt zur Garde</Headline>
    <p>
      Sie möchten mit uns in Kontakt treten? Wir freuen uns auf ihre E-Mail.
    </p>
    <div id="kontakte">
      <Contacts :contacts="[marcel, markus, alex]" />
    </div>
  </div>
</template>

<script>
import ImageMarcel from '../assets/photos/potraits/marcel.jpg';
import ImageMarkus from '../assets/photos/potraits/markus.jpg';
import ImageAlex from '../assets/photos/potraits/alexander.jpg';
import Contacts from '../components/organisms/Contacts.vue';
import Headline from '../components/atoms/Headline.vue';

export default {
  name: 'Kontakte',
  components: { Headline, Contacts },
  data() {
    return {
      marcel: {
        image: ImageMarcel,
        name: 'Marcel Thran',
        position: 'Geschäftsführer',
        email: 'geschaeftsfuehrer@ehrengarde-neuwied.de',
      },
      markus: {
        image: ImageMarkus,
        name: 'Markus Schröder',
        position: 'Präsident',
        email: 'praesident@ehrengarde-neuwied.de',
      },
      alex: {
        image: ImageAlex,
        name: 'Alexander Wertgen',
        position: 'Kommandeur',
        email: 'kommandeur@ehrengarde-neuwied.de',
      },
    };
  },
};
</script>
