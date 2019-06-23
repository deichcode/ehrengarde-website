<style scoped>

</style>

<template>
    <div class="content">
        <h2 class="title">Termine</h2>
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
</template>

<script>
import moment from 'moment';
import axios from 'axios';
import Event from '../components/molecules/Event.vue';

export default {
  name: 'Termine',
  components: { Event },
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
      // .get('http://localhost:5000/api/Calendar')
      // .get('http://10.0.42.24:5000/api/Calendar')
      .get('http://192.168.178.21:5000/api/Calendar')
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
