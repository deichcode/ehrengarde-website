<style scoped>

</style>

<template>
  <div class="content">
    <h2 class="title">Termine</h2>
    <Event v-for="event in events" :title="event.title" :description="event.description" :date="event.date"
           :location="event.location "></Event>
  </div>
</template>

<script>
import moment from 'moment';
import Event from '../components/molecules/Event.vue';

export default {
  name: 'Termine',
  components: { Event },
  data() {
    return {
      events: [
        {
          date: moment('2019-05-15'),
          title: 'Sommerfest Festausschuss',
          location: 'Raiffeisenschule',
        },
        {
          date: moment('2019-06-23'),
          title: 'Vortour der Hoffnung',
          location: 'Lahnstein',
        },
        {
          date: moment('2019-07-11'),
          title: 'Deichstadtfest',
          location: 'Neuwied',
        },
        {
          date: moment('2019-07-12'),
          title: 'Deichstadtfest',
          location: 'Neuwied',
        },
        {
          date: moment('2019-07-13'),
          title: 'Deichstadtfest',
          location: 'Neuwied',
        },
        {
          date: moment('2019-07-14'),
          title: 'Deichstadtfest',
          location: 'Neuwied',
        },
      ],
    };
  },
};
</script>
