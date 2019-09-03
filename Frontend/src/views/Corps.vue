<style scoped>

</style>

<template>
  <div class="content">
    <h2 class="title">Die Korps der Garde</h2>
    <p>Ehrengarde ... großer Verein ... so much wow ...
      awesom corps ... come and join ... etc. </p>
   <Separator></Separator>
    <div class="corps">
      <TopicHeader :src="piccolos" name="DAS PICCOLOCORPS" beschreibung="Das Piccolocrops ...
      Kinder von 0 bis 14 Jahren ... jedes Jahr einen Garde und
      einen Showtanz. Jeder kann gerne mittmachen ...
      Proben finden ab MONAT jeden Freitag um UHRZEIT statt."></TopicHeader>
      <Activity :src="freizeitPicccolo" beschreibung="Neben Tanzen auch andere Aktionen ...
       Wenn Du mitmachen möchtest, sprich uns doch einfach bei einem unserer Auftritte an,
       schau bei den Proben vorbei oder wende dich an die Piccolobetreuung."></Activity>
      <Contact :src="alex" position="Piccolobetreuung" name="Melanie Klein"
               email="piccolos@ehrengarde-neuwied.de"></Contact>
      <Separator></Separator>

      <TopicHeader :src="garde" name="DIE AKTIVE GARDE" beschreibung="Aktive Garde ...
      Große Flaschen ... Ganz viel Spaß ... Noch mehr Text den keiner ließt"></TopicHeader>
      <Contact :src="alex" position="Kommandeur" name="Alexander Wertgen"
               email="kommandeur@ehrengarde-neuwied.de"></Contact>
      <Separator></Separator>

      <TopicHeader :src="reservisten" name="DIE RESERVISTEN" beschreibung="Reservisten ...
      voll die tollen Menschen ... seit JAHR fester bestandteil des Gardetanz
      ... voll gut das es die gibt."></TopicHeader>
      <Contact :src="alex" position="Kommandeur" name="Günter Kutscher"
               email="guenter.kutscher@ehrengarde-neuwied.de"></Contact>
      <Separator></Separator>

      <TopicHeader :src="ehrenoffiziere" name="DIE EHRENOFFIZIERE" beschreibung="Alte Männer
      plus eine Frau ... so extremely important ... oh my good look at his
       hat so cool"></TopicHeader>
      <Contact :src="alex" position="Kommandeur" name="Hans-Wilhelm Schaback"
               email="hans-wilhelm.schaback@ehrengarde-neuwied.de"></Contact>
      <Separator></Separator>
    </div>
  </div>
</template>

<script>

import Contact from '../components/molecules/Contact.vue';
import Activity from '../components/molecules/Activity.vue';
import TopicHeader from '../components/molecules/TopicHeader.vue';
import Separator from '../components/atoms/Separator.vue';

import piccolos from '../assets/photos/2019/sitzung/piccolos.jpg';
import garde from '../assets/photos/2019/sitzung/garde.jpg';
import reservisten from '../assets/photos/2019/sitzung/reservisten.jpg';
import ehrenoffiziere from '../assets/photos/2018/sitzung/ehrenoffiziere.jpg';

import freizeitPicccolo from '../assets/photos/2019/freizeitPiccolo.jpg';
import alex from '../assets/photos/potraits/alexander.jpg';


export default {
  name: 'Corps',
  components: {

    Separator, TopicHeader, Activity, Contact,
  },
  data() {
    return {
      piccolos,
      garde,
      reservisten,
      ehrenoffiziere,
      alex,
      freizeitPicccolo,
    };
  },
};
</script>
