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

            .event_location_map {
                padding-top: 10px;
                flex-basis: 146px;
            }

            .event_location_address {
                margin-top: 5px;
            }
        }
    }
</style>

<template>
    <div class="event">
        <div class="event_datetime">
            <span class="event_weekday">{{start | moment('dddd')}}</span>
            <span class="event_day">{{start | moment('D')}}</span>
            <span class="event_month">{{start | moment('MMMM')}}</span>
            <span class="event_year">{{start | moment('Y')}}</span>
            <span class="event_time" v-if="!isAllDay">{{start | moment('H:mm')}} Uhr</span>
        </div>
        <div class="event_details">
            <span class="event_title">{{title}}</span>
            <span class="event_description" v-if="description">{{description}}</span>
            <div class="event_location_map" v-if="location">
                <Location :location="location"></Location>
            </div>
            <span class="event_location_address" v-if="location">{{location}}
                <a v-if="isIOS || isMacOS" :href="'http://maps.apple.com/?daddr='+location">
                    <font-awesome-icon icon="directions" :style="{ color: 'white'}"/>
                </a>
                <a v-if="isAndroid" :href="'https://www.google.com/maps/dir/?api=1&destination='+location">
                    <font-awesome-icon icon="directions" :style="{ color: 'white'}"/>
                </a>
                <a v-if="isWinPhone" :href="'ms-drive-to:?destination.name='+location">
                    <font-awesome-icon icon="directions" :style="{ color: 'white'}"/>
                </a>
                <a v-if="!isMobile && !isMacOS" :href="'https://www.google.com/maps/dir/?api=1&destination='+location"
                   target="_blank">
                    <font-awesome-icon icon="directions" :style="{ color: 'white'}"/>
                </a>
            </span>
        </div>
    </div>

</template>

<script>
import moment from 'moment';
import {
  isIOS, isAndroid, isWinPhone, isMobile, osName,
} from 'mobile-device-detect';
import Location from '../atoms/Location.vue';

export default {
  name: 'Event',
  components: { Location },
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
    };
  },
};
</script>
