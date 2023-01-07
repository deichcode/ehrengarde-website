<style scoped lang="scss">
    .titel{
        font-weight: bold;
    }

    .group{
        margin-bottom: 20px;
    }
</style>

<template>
    <div class="content">
        <Headline styling="page-title" :level=2>Prinzenpaare der Ehrengarde</Headline>
        <Separator />
        <div id="prinzenpaare">
            <div class="prinzenpaar">
                <TopicHeader id="michaela_markus" :src="michaelaMarkus" title="Prinzenpaar 2019/2020" />
                <div class="titel">
                    <ParagraphWide>
                        Ex-Prinz Markus - Die spitze Feder von der Ehrengarde
                    <ParagraphWide>
                    </ParagraphWide>
                        Ex-Prinzessin Michaela vom Römerkastell am Wiedesstrand
                    </ParagraphWide>
                </div>
                <Separator />
            </div>
            <div class="prinzenpaar">
                <TopicHeader id="ulrike_gerd" :src="ulrikeGerd" title="Prinzenpaar 2008/2009" />
                <div class="titel">
                    <ParagraphWide>
                        Ex-Prinz Gerd I vom Hause Neoweda, Herr von Langendorf und Sonnenland
                    </ParagraphWide>
                    <ParagraphWide>
                        Ex-Prinzessin Ulrike II von Landsberg / Kettwig zu Rhenania Neoweda Comtesse de Coiffeur
                    </ParagraphWide>
                </div>
                <Separator />
            </div>

            <div class="prinzenpaar">
                <TopicHeader id="hanelore_mini" :src="haneloreMini" title="Prinzenpaar 1997/1998" />
                <div class="titel">
                    <ParagraphWide>
                        Ex-Prinz Mini I von der Ehrengarde
                    </ParagraphWide>
                    <ParagraphWide>
                        Ex-Prinzessin Hannelore von Rat und Medien
                    </ParagraphWide>
                </div>
                <Separator />
            </div>
            <div class="prinzenpaar">
                <TopicHeader id="brigitte_micahel" :src="brigitteMichael" title="Prinzenpaar 1986/1987" />
                <div class="titel">
                    <ParagraphWide>
                        Ex-Prinz Hans-Michael I von Friedrichstein
                    </ParagraphWide>
                    <ParagraphWide>
                        Ex-Prinzessin Brigitte-Ursula I von den blauen Pfauen
                    </ParagraphWide>
                </div>
                <Separator />
            </div>

            <div class="prinzenpaar">
                <TopicHeader id="giselaRobert" :src="giselaRobert" title="Prinzenpaar 1975/1976" />
                <div class="titel">
                    <ParagraphWide>
                        Ex-Prinz Robert I von der Paragraphenburg
                    </ParagraphWide>
                    <ParagraphWide>
                        Ex-Prinzessin Gisela I von Hospitalien
                    </ParagraphWide>
                </div>
                <Separator />
            </div>
        </div>
    </div>
</template>

<script>
import Separator from '../components/atoms/Separator.vue';
import TopicHeader from '../components/molecules/TopicHeader.vue';
import ParagraphWide from '../components/atoms/ParagraphWide.vue';
import Headline from '../components/atoms/Headline.vue';

import michaelaMarkus from '../assets/photos/prinzenpaare/michaela-markus.jpg';
import ulrikeGerd from '../assets/photos/prinzenpaare/ulrike-gerd.jpg';
import haneloreMini from '../assets/photos/prinzenpaare/hanelore-mini.jpg';
import brigitteMichael from '../assets/photos/prinzenpaare/brigitte-michael.jpg';
import giselaRobert from '../assets/photos/prinzenpaare/gisela-robert.jpg';

export default {
  name: 'Hofstaat',
  components: {
    TopicHeader,
    Separator,
    ParagraphWide,
    Headline,
  },
  data() {
    return {
      michaelaMarkus,
      ulrikeGerd,
      haneloreMini,
      brigitteMichael,
      giselaRobert,
    };
  },
};
</script>
