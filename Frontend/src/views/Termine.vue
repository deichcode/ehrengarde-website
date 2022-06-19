<style scoped lang="scss">
  .events_wrapper {
    display: flex;
    justify-content: space-around;
    flex-direction: row;
    flex-wrap: wrap;
  }

  .is-loading {
    text-align: center;
    columns: unset;
  }

  .no-events {
    text-align: center;
    columns: unset;
  }

</style>

<template>
  <div class="content">
    <Headline :level=2 styling="page-title">Termine</Headline>
    <Paragraph class="is-loading" v-if="isLoading">Termine werden geladen…</Paragraph>
    <Paragraph class="no-events" v-if="noEvents">Aktuell stehen keine Termine an.</Paragraph>
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
import moment from 'moment-timezone';
import axios from 'axios';
import Event from '../components/molecules/Event.vue';
import Headline from '../components/atoms/Headline.vue';
import Paragraph from '../components/atoms/Paragraph.vue';

export default {
  name: 'Termine',
  components: { Paragraph, Headline, Event },
  data() {
    return {
      events: [],
      yesterday: moment().subtract(1, 'days'),
      isLoading: true,
    };
  },
  computed: {
    currentEvents() {
      return this.events.filter((e) => e.start.isAfter(this.yesterday));
    },
    noEvents() {
      return !this.isLoading && !this.events.length;
    },
  },
  mounted() {
    axios
      .get(`${process.env.VUE_APP_API}/calendar`)
      .then((response) => {
        this.events = response.data.map(
          (event) => ({
            ...event,
            start: moment.parseZone(event.start),
            end: moment.parseZone(event.start),
          }),
        );
        this.isLoading = false;
      });
  },
};
</script>
