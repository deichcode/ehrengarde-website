<template>
    <div class="content">
        <Headline :level=2 styling="page-title">Die Chronik der Garde</Headline>
        <Separator/>

    </div>
</template>

<script>

import Separator from '../components/atoms/Separator.vue';
import Headline from '../components/atoms/Headline.vue';

export default {
  name: 'chronik',
  components: {
    Headline, Separator,
  },
};
</script>
