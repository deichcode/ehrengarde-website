<style scoped lang="scss">
  @media (min-width: 500px) {
    .event {
      margin-right: 10px;
      margin-left: 10px;
    }
  }
  .event {
    display: flex;
    flex-flow: column;
    margin-bottom: 20px;
    text-align: center;
    flex: 0 1 280px;

    .event_title {
      font-size: 1.286rem;
      margin-bottom: 5px;
      margin-top: 0;
    }

    .event_datetime {
      margin-top: 5px;
      margin-bottom: 10px;

      .event_calendar_icon {
        margin-bottom: 4px;
        margin-top: 2px;
        height: 20px;
        width: auto;
      }
    }

    .event_location {
      height: 150px;
      margin-right: -10px;
      margin-left: -10px;
      flex-grow: 1;
      /*position: absolute;*/
      margin-top: auto;
      display: flex;
      flex-direction: column;

      div {
        margin-top: auto;
      }
    }

    .event_description {
      margin-top: 10px;
      display: inline-block;
    }

    .event_location_address {
      display: inline-block;
      margin-bottom: 5px;

      .event-direction_icon {
        height: 20px;
        width: auto;
      }
    }
  }

</style>

<template>
  <Card class="event" v-if="isVisible">
    <p class="event_title">{{title}}</p>
    <p class="event_datetime">
      <!--      <font-awesome-icon icon="calendar-alt" class="event_calendar_icon"/>-->
      <!--      <br/>-->
      {{start | moment('dd')}}. {{start | moment('D')}}.
      {{start | moment('MMMM')}} {{start | moment('Y')}}
      <span class="event_time" v-if="!isAllDay">
        <br/>
        um {{start | moment('H:mm')}} Uhr
      </span>
    </p>

    <div class="event_location" v-if="location">
      <Location :location="location"></Location>
    </div>

    <span class="event_description" v-if="description">{{description}}</span>
    <br/>
    <span class="event_location_address" v-if="location">
      <br/>
      <a class="no-underline" v-if="isIOS || isMacOS"
         :href="'http://maps.apple.com/?daddr='+location">
          <font-awesome-icon class="event-direction_icon" icon="directions"
                             :style="{ color: 'white'}"/>
      </a>
      <a class="no-underline" v-if="isAndroid"
         :href="'https://www.google.com/maps/dir/?api=1&destination='+location">
          <font-awesome-icon class="event-direction_icon" icon="directions"
                             :style="{ color: 'white'}"/>
      </a>
      <a class="no-underline" v-if="isWinPhone" :href="'ms-drive-to:?destination.name='+location">
          <font-awesome-icon class="event-direction_icon" icon="directions"
                             :style="{ color: 'white'}"/>
      </a>
      <a class="no-underline" v-if="!isMobile && !isMacOS"
         :href="'https://www.google.com/maps/dir/?api=1&destination='+location"
         target="_blank">
          <font-awesome-icon class="event-direction_icon" icon="directions"
                             :style="{ color: 'white'}"/>
      </a>
      <br/>
      {{location}}
    </span>
  </Card>
</template>

<script>
import moment from 'moment';
import {
  isIOS, isAndroid, isWinPhone, isMobile, osName,
} from 'mobile-device-detect';
import Location from '../atoms/Location.vue';
import Card from '../atoms/Card.vue';

export default {
  name: 'Event',
  components: { Card, Location },
  props: {
    uid: String,
    title: String,
    description: String,
    start: moment,
    end: moment,
    isAllDay: Boolean,
    location: String,
  },
  data() {
    return {
      isIOS,
      isAndroid,
      isWinPhone,
      isMobile,
      isMacOS: osName.includes('Mac'),
      isVisible: true, // Track visibility
    };
  },
  mounted() {
    this.setupIntersectionObserver();
    this.isVisible = true;
  },
  methods: {
    setupIntersectionObserver() {
      const options = {
        root: null,
        rootMargin: '0px',
        threshold: 0.5,
      };

      const callback = (entries, observer) => {
        entries.forEach((entry) => {
          // debugger;
          if (entry.isIntersecting) {
            this.isVisible = true;
            observer.unobserve(entry.target);
          }
        });
      };

      const observer = new IntersectionObserver(callback, options);
      observer.observe(this.$el);
    },
  },
};
</script>
