<style scoped lang="scss">
  .corps {
    display: flex;
    flex-direction: column;
  }

  p{
    color: white;
    text-align: center;
    font-size: 2.0rem;

  }
</style>

<template>
  <div class="content">
    <p class="title">Die Korps der Garde</p>
    <Separator/>
    <div class="corps">
      <TopicHeader id="piccolos" :src="piccolos" name="DAS PICCOLOCORPS"
      beschreibung="Den Piccolotanz üben die Kinder mit Hilfe ihrer Piccolobetreuung ein. Hierbei ist es der Garde
      besonders wichtig, dass die Kinder auch Kind sein dürfen. Perfektion liegt dem Piccolokorps fern. Diese liegt
      eher in der Spontanität und ihr ist Genüge getan, wenn die Kleinen mit Ende der Musik ihren Tanz
      vollendet haben. Mit 14 Jahren haben die Piccolos dann ausreichende „Flaschenreifung“ genossen, um voller
      Tatendrang in ihr Gardeleben als aktives Mariechen oder aktiver Gardist der Ehrengarde durchzustarten. "/>

      <Activity :src="freizeitPicccolo" beschreibung=" Neben dem Karneval und der Historie gibt es  auch viele
      andere Aktionen, welche innerhalb der Garde stattfinden wie beispielsweise hier auf dem Foto zusehen der Bau
      eines Insektenhotels während des all jährlichen Pfingstzeltlager. Wenn Du mitmachen möchtest, sprich uns doch
      einfach bei einem unserer Auftritte an, schau bei den Proben vorbei oder wende dich an die Piccolobetreuung."/>
      <Contacts :contacts="[
      {image: platzhalterM,
      position: 'Piccolobetreuung',
      name: 'Melanie Klein',
      email: 'piccolos@ehrengarde-neuwied.de'}]"/>
      <Separator/>

      <TopicHeader id="aktive" :src="garde" name="DIE AKTIVE GARDE"
      beschreibung="Manch einer denkt wohl, dass es sich beim „Aktiven Corps“ um die jungen Wilden des Vereins handelt.
      Weit gefehlt. Denn die Zugehörigkeit zum Aktiven Korps richtet sich weniger nach dem Alter, sondern vielmehr
      nach dem Grad der Aktivität. Wer also etwas mehr Zeit investieren möchte, ist hier genau richtig. Ob beim
      eifrigen Tanzbein schwingen im Gardetanz oder bei Serviceeinsätzen wie z. B. beim Sommerfest des
      Festausschusses, dem Deichstadtfest oder im Heerlager bei den Markttagen – das Aktive Korps ist immer im
      Einsatz. Wenn Du mitmachen möchtest, sprich uns doch einfach bei einem unserer Auftritte an, schau bei den Proben
      vorbei oder schreib uns, wir freuen uns auf jedes neue Gesicht."/>
      <Contacts :contacts="[
      {image: alex,
      position: 'Kommandeur',
      name: 'Alexander Wertgen',
      email: 'kommandeur@ehrengarde-neuwied.de'}]"/>
      <Separator/>

      <TopicHeader id="reservisten" :src="reservisten" name="DIE RESERVISTEN"
       beschreibung="Von wegen die Reserve hat Ruh… Unsere Reservisten gehören noch lange nicht zum alten
       Eisen. Ganz im Gegenteil. Sie werden nach wie vor gebraucht und unterstützen den Verein mit Know How, Ideen und
       oft genug mit helfenden Händen. So manch einer hat sich in den letzten Jahren auch wieder aktiv im Gardetanz
       als sogenannte „tanzende Reserve“ eingebracht. Die Grenzen verlaufen hier fließend und sind auch für alte Hasen
       nicht immer leicht zu durchschauen.  Wenn Du mitmachen möchtest, sprich uns doch einfach bei einem unserer
       Auftritte an, schau bei den Proben vorbei oder schreib uns, wir freuen uns auf jedes neue Gesicht."/>
      <Contacts :contacts="[
      {image: platzhalterM,
      position: 'Kommandeur',
      name: 'Günter Kutscher',
      email: 'guenter.kutscher@ehrengarde-neuwied.de'}]"/>
      <Separator/>

      <TopicHeader id="eos" :src="ehrenoffiziere" name="DIE EHRENOFFIZIERE"
      beschreibung="Seit 2002 leitet Hans-Wilhelm Schaback das Korps als Kommandeur und ist ein wichtiges Bindeglied
      zwischen den Ehrenoffizieren und der restlichen Garde und leitet als Mitglied des erweiterten Vorstandes
      die Geschicke des Vereins mit. Neben der ideellen und finanziellen Unterstützung stellt das Ehrenoffizierskorps
      bei der Traditionellen Gardesitzung den Elferrat. Aber viele der Ehrenoffiziere tragen auch Uniform und
      unterstützen die Garde bei ihren verschiedenen Auftritten im Karneval und der Historie. Traditionell werden
      ein bis zwei Ehrenoffiziere pro Jahr neu ernannt. Die Offiziersrunde schlägt in jedem Jahr verdiente Mitglieder
       der Garde oder verdiente Karnevalisten aus Politik und Wirtschaft vor. Über die Vorschläge wird innerhalb des
       Ehrenoffizierskorps abgestimmt. "/>
      <Contacts :contacts="[
      {image: platzhalterM,
      position: 'Kommandeur',
      name: 'Hans-Wilhelm Schaback',
      email: 'hans-wilhelm.schaback@ehrengarde-neuwied.de'}]"/>
      <Separator/>
    </div>
  </div>
</template>

<script>
import Activity from '../components/molecules/Activity.vue';
import TopicHeader from '../components/molecules/TopicHeader.vue';
import Separator from '../components/atoms/Separator.vue';
import Contacts from '../components/organisms/Contacts.vue';

import piccolos from '../assets/photos/2019/sitzung/piccolos.jpg';
import garde from '../assets/photos/2019/sitzung/garde.jpg';
import reservisten from '../assets/photos/2019/sitzung/reservisten.jpg';
import ehrenoffiziere from '../assets/photos/2018/sitzung/ehrenoffiziere.jpg';

import freizeitPicccolo from '../assets/photos/2019/freizeitPiccolo.jpg';
import alex from '../assets/photos/potraits/alexander.jpg';
import platzhalterM from '../assets/photos/potraits/platzhalterM.jpg';

export default {
  name: 'Corps',
  components: {
    Contacts,

    Separator,
    TopicHeader,
    Activity,
  },
  data() {
    return {
      piccolos,
      garde,
      reservisten,
      ehrenoffiziere,
      alex,
      platzhalterM,
      freizeitPicccolo,
    };
  },
};
</script>
