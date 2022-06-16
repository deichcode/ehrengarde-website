<style scoped lang="scss">
</style>

<template>
  <div class="content">
    <Headline :level=2 styling="page-title">Kontakt zur Garde</Headline>
    <Seperator/>
    <p>
      Sie möchten mit uns in Kontakt treten? Wir freuen uns auf ihre E-Mail.
    </p>
    <div id="kontakte">
      <Contacts :contacts="[marcel, markus, alex]" />
    </div>
    <Seperator/>
    <SocialMedia/>
  </div>
</template>

<script>
import ImagePlaceholder from '../assets/photos/potraits/placeholder.png';
import ImageMarkus from '../assets/photos/potraits/markus.jpg';
import ImageAlex from '../assets/photos/potraits/alexander.jpeg';
import Contacts from '../components/organisms/Contacts.vue';
import Headline from '../components/atoms/Headline.vue';
import Seperator from '../components/atoms/Separator.vue';
import SocialMedia from '../components/atoms/SocialMedia.vue';

export default {
  name: 'Kontakte',
  components: {
    SocialMedia, Headline, Contacts, Seperator,
  },
  data() {
    return {
      marcel: {
        image: ImagePlaceholder,
        name: 'Stefan Kugler',
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
