<style scoped lang="scss">
    .sponsor-wrapper {
        display: flex;
        justify-content: space-around;
        flex-wrap: wrap;
    }
</style>

<template>
    <div class="sponsor-wrapper">
        <Sponsor v-for="(sponsor, index) in sponsors"
                 :key="index"
                 :image="sponsor.image"
                 :name="sponsor.name"
                 :link="sponsor.link"
        />
    </div>
</template>

<script>
import Sponsor from '../molecules/Sponsor.vue';

export default {
  name: 'Sponsors',
  components: { Sponsor },
  props: {
    sponsors: Array,
  },
};
</script>
