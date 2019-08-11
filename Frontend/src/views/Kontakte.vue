<style scoped lang="scss">
  #kontakte {
    display: flex;
    justify-content: space-around;
    flex-wrap: wrap;
  }
</style>

<template>
  <div class="content">
    <h2 class="title">Kontakt zur Garde</h2>
    <p>
      Sie möchten uns in Kontakt treten? Wir freuen uns auf ihre Nachricht per E-Mail.
      Für generelle Fragen können Sie sich gerne an einen der folgenden Personen wenden.
    </p>
    <div id="kontakte">
      <Contact :src="marcel" position="Geschäftsführer" name="Marcel Thran"
               email="geschaeftsfuehrer@ehrengarde-neuwied.de"></Contact>
      <Contact :src="markus" position="Präsident" name="Markus Schröder"
               email="praesident@ehrengarde-neuwied.de"></Contact>
      <Contact :src="alex" position="Kommandeur" name="Alexander Wertgen"
               email="kommandeu@ehrengarde-neuwied.de"></Contact>
    </div>
  </div>
</template>

<script>
import Contact from '../components/molecules/Contact.vue';
import marcel from '../assets/photos/potraits/marcel.jpg';
import markus from '../assets/photos/potraits/markus.jpg';
import alex from '../assets/photos/potraits/alexander.jpg';

export default {
  name: 'Kontakte',
  components: { Contact },
  data() {
    return {
      marcel,
      markus,
      alex,
    };
  },
};
</script>
