<style scoped>

</style>

<template>
  <div class="content">
    <Headline styling="page-title" :level=2>Die Traumtänzer der Garde</Headline>
    <Separator/>
    <div class="traumtaenzer">
      <TopicHeader id="traumtaenzer" :src="traumtaenzer" title="Die Traumtänzer"/>
      <Paragraph>
        Unter der Leitung von Mareike Meenen bringen die Traumtänzer jedes Jahr einen neuen Showtanz
        hervor und
        begeistern ihr Publikum mit tollen Themen. Die Traumtänzer trainieren jährlich ab Ostern
        einmal wöchentlich
        und bringen dabei ihre Trainerin regelmäßig an den Rande des Wahnsinns. Der Spaß am Tanzen
        und der Zusammenhalt der
        Gruppe wird hier groß geschrieben. Dazu gehören auch gemeinsame Ausflüge und Aktionen. Ob
        Köln oder
        Rüdesheim, Schiff oder Bahn - der Spaß fährt immer mit. Das Schöne an den Traumtänzern ist,
        dass es nach oben
        keine Altersgrenze gibt. So sind die aktiven Tänzerinnen und Tänzer im Alter zwischen 14 und
        48 Jahren. Wenn
        Du mitmachen möchtest, sprich uns doch einfach bei einem unserer Auftritte an, schau bei den
        Proben vorbei
        oder schreib uns, wir freuen uns auf jedes neue Gesicht.
      </Paragraph>
      <Contacts :contacts="[
      {
      position: 'Leitung',
      name: 'Mareike Meenen',
      email: 'kontakt-traumtaenzer@ehrengarde-neuwied.de'}]"/>
    </div>
    <Separator/>
    <SocialMedia></SocialMedia>
  </div>
</template>

<script>
import TopicHeader from '../components/molecules/TopicHeader.vue';
import Separator from '../components/atoms/Separator.vue';
import Contacts from '../components/organisms/Contacts.vue';
import Paragraph from '../components/atoms/Paragraph.vue';
import Headline from '../components/atoms/Headline.vue';
import SocialMedia from '../components/atoms/SocialMedia';

import traumtaenzer from '../assets/photos/2019/traumtaenzer.jpeg';

export default {
  name: 'Traumtaenzer',
  components: {
    SocialMedia,
    Headline,
    Paragraph,
    Contacts,
    Separator,
    TopicHeader,

  },
  data() {
    return {
      traumtaenzer,
    };
  },
};
</script>
