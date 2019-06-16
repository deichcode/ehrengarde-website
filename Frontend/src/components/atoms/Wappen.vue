<template>
  <img :src="path" alt=""/>
</template>

<script>
import wappenAktive from '../../assets/wappen/aktive_garde.svg';
import wappenPiccolos from '../../assets/wappen/piccolos.svg';
import wappenReservisten from '../../assets/wappen/reservisten.svg';
import wappenEhrengoffiziere from '../../assets/wappen/ehrenoffiziere.svg';

export default {
  name: 'Wappen',
  props: {
    corps: {
      type: String,
      validator: value => ['aktive', 'piccolos', 'reservisten', 'eos'].includes(value),
    },
  },
  computed: {
    path() {
      switch (this.corps) {
        case 'aktive':
          return wappenAktive;
        case 'piccolos':
          return wappenPiccolos;
        case 'reservisten':
          return wappenReservisten;
        case 'eos':
          return wappenEhrengoffiziere;
        default:
          return wappenAktive;
      }
    },
  },
};
</script>

<style scoped>
img {
  width: 30px;
  height: 37px;
}
</style>
