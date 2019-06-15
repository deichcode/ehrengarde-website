<style scoped lang="scss">
  .event {
    color: $white;
    background: $light-blue;
    display: flex;
    flex-flow: row;
    margin-bottom: 20px;

    .event_datetime {
      display: flex;
      flex: 0 0 100px;
      flex-flow: column;
      border-right: 2px dotted white;
      padding: 10px;
      text-align: center;
      justify-content: center;

      .event_weekday {
        font-size: 1rem;
      }

      .event_day {
        font-size: 4rem;
      }

      .event_month {
        font-size: 1.06rem;
      }

      .event_year {
        font-size: 2.34rem;
      }

      .event_time {
        font-size: 1.1rem;
      }
    }

    .event_details {
      display: flex;
      flex-flow: column;
      flex-grow: 1;
      padding: 10px;

      .event_title {
        font-variant: small-caps;
      }

      .event_description {
        padding-top: 10px;
      }

      .event_location {
        padding-top: 10px;
        flex-basis: 146px;
      }
    }
  }
</style>

<template v-if="isVisible">
  <div class="event">
    <div class="event_datetime">
      <span class="event_weekday">{{date | moment('dddd')}}</span>
      <span class="event_day">{{date | moment('D')}}</span>
      <span class="event_month">{{date | moment('MMMM')}}</span>
      <span class="event_year">{{date | moment('Y')}}</span>
      <span class="event_time">{{date | moment('H:mm')}} Uhr</span>
    </div>
    <div class="event_details">
      <span class="event_title">{{title}}</span>
      <span class="event_description" v-if="description">{{description}}</span>
      <div class="event_location">
        <Location :location="location"></Location>
      </div>
    </div>
  </div>

</template>

<script>
import moment from 'moment';
import Location from '../atoms/Location.vue';

export default {
  name: 'Event',
  components: { Location },
  props: {
    date: moment,
    title: String,
    description: String,
    location: String,
  },
};
</script>
