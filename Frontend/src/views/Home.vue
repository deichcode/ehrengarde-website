<template>
  <div class="content">
    <Headline :level=2 styling="page-title">Wilkommen bei der Garde</Headline>
    <Separator></Separator>
    <TopicHeader :src="karneval" title="Der Karneval"/>
    <Paragraph>
      Mit mehr als 80 Uniformierten stellt die Ehrengarde in der Deichstadt die größte
      Garde. Besonders stolz ist
      die Garde auf ihre Vielzahl eigener Gewächse. Hierzu zählt natürlich die Aktive Garde mit
      ihrem alljährlichen
      Gardetanz, die Showtanzgruppe „Traumtänzerkompanie“, das Piccolokorps, mehrere Büttenredner
      aus den eigenen Reihen
      und Bühnenstücke der Reservisten der Garde. So ist es kaum verwunderlich, dass die Ehrengarde
      das eigene
      Sitzungsprogramm fast ausschließlich
      aus den eigenen Reihen bestreiten kann. Wenn die eigene Sitzung dann erfolgreich gemeistert
      wurde, steht für die
      Garde der reine Spaß im Vordergrund. Diesen Spaß versucht sie von der Bühne ins Publikum zu
      übertragen. Dabei ist
      die Garde gern gesehener Bühnengast bei unzähligen Veranstaltungen in und um Neuwied, aber
      auch weit
      über die Stadtgrenzen hinaus. Spätestens, wenn es dann an den Straßenkarneval geht, ist die
      Ehrengarde
      kaum zu übersehen.
    </Paragraph>
    <Separator></Separator>
    <TopicHeader :src="historisch" title="Die Historie"/>
    <Paragraph>
      Anlässlich der 300-Jahr-Feier der Stadt Neuwied wurde eine Gruppe junger Männer mit
      originalgetreuen Uniformen der wiedischen Grenadiere eingekleidet.
      Diese Gruppe stellt im Festumzug zum Stadtjubiläum 1953 einen historisch bedeutsamen Teil der
      Stadtgeschichte dar. Dies war die Geburtsstunde der Ehrengarde der Stadt Neuwied. Ihrer
      historischen Rolle werden
      die Grenadiere der Garde in ihren originalgetreuen Uniformen als Repräsentant der Stadt
      Neuwied noch heute gerecht.
      Bei Anlässen wie Rheinland-Pfalz-Tagen, Empfängen und historischen Festen oder
      Städtepartnerschaften verstehen sie
      sich als ein Stück Stadtgeschichte zum Anfassen. Bei historischen Anlässen tragen die Damen
      des Vereins handgemachte
      Gewandungen, die dem weiblichen, einfachen Volk um 1750 entspricht.
    </Paragraph>
    <Separator/>
    <SocialMedia/>
  </div>
</template>

<script>
import karneval from '../assets/photos/2019/karneval.jpg';
import historisch from '../assets/photos/2019/historisch.jpg';
import TopicHeader from '../components/molecules/TopicHeader.vue';
import Separator from '../components/atoms/Separator.vue';
import Paragraph from '../components/atoms/Paragraph.vue';
import Headline from '../components/atoms/Headline.vue';
import SocialMedia from '../components/atoms/SocialMedia';

export default {
  name: 'home',
  components: {
    SocialMedia,
    Headline,
    Paragraph,
    Separator,
    TopicHeader,
  },
  data() {
    return {
      karneval,
      historisch,
    };
  },
};
</script>
