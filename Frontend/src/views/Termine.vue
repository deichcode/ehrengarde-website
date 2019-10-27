<style scoped lang="scss">
  .events_wrapper {
    display: flex;
    justify-content: space-around;
    flex-direction: row;
    flex-wrap: wrap;
  }

</style>

<template>
  <div class="content">
    <Headline :level=2 styling="page-title">Termine</Headline>
    <div class="events_wrapper">
      <Event v-for="event in currentEvents"
             :key="event.uid"
             :title="event.title"
             :description="event.description"
             :start="event.start"
             :end="event.end"
             :is-all-day="event.isAllDay"
             :location="event.location">
      </Event>
    </div>
  </div>
</template>

<script>
import moment from 'moment';
import axios from 'axios';
import Event from '../components/molecules/Event.vue';
import Headline from '../components/atoms/Headline.vue';

export default {
  name: 'Termine',
  components: { Headline, Event },
  data() {
    return {
      events: [],
      yesterday: moment().subtract(1, 'days'),
    };
  },
  computed: {
    currentEvents() {
      return this.events.filter(e => e.start.isAfter(this.yesterday));
    },
  },
  mounted() {
    axios
      .get(`${process.env.VUE_APP_API}/calendar`)
      .then((response) => {
        this.events = response.data.map(
          event => ({
            ...event,
            start: moment(event.start),
            end: moment(event.end),
          }),
        );
      });
  },
};
</script>
