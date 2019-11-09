<style scoped lang="scss">
</style>

<template>
    <div class="content">
        <Headline :level=2 styling="page-title">Unsere Sponsoren</Headline>
        <Seperator/>
        <div id="sponsoren">
            <Sponsors :sponsors="[bitburger, sparkasse, swn, volksbank]" />
        </div>
    </div>
</template>

<script>
import ImageBitburger from '../assets/photos/sponsoren/bitburger.png';
import ImageSparkasse from '../assets/photos/sponsoren/sparkasse.png';
import ImageVolksbank from '../assets/photos/sponsoren/volksbank.png';
import ImageSWN from '../assets/photos/sponsoren/swn.jpg';

import Headline from '../components/atoms/Headline.vue';
import Seperator from '../components/atoms/Separator.vue';
import Sponsors from '../components/organisms/Sponsors.vue';

export default {
  name: 'Sponsoren',
  components: {
    Sponsors, Headline, Seperator,
  },
  data() {
    return {
      bitburger: {
        image: ImageBitburger,
        name: 'Bitburger',
        link: 'https://www.bitburger.de/',
      },
      sparkasse: {
        image: ImageSparkasse,
        name: 'Sparkasse Neuwied',
        link: 'https://www.sparkasse-neuwied.de/',
      },
      swn: {
        image: ImageSWN,
        name: 'SWN',
        link: 'https://www.swn-neuwied.de/',
      },
      volksbank: {
        image: ImageVolksbank,
        name: 'VR-BANK Neuwied-Linz',
        link: 'https://www.vrbn.de/',
      },
    };
  },
};
</script>
