<style scoped lang="scss">
  nav.main-navigation {
    position: sticky;
    top: 0;
    background-color: $white;
    display: flex;
    justify-content: space-evenly;
    padding: $default-spacer;
    padding-bottom: 0;
    flex-wrap: wrap;
    box-shadow: 0 3px 6px $shadow;
    z-index: 20;
    height: 31px;

    a, a.show-more {
      @include navigation-link;
    }
  }

  nav.overflow-navigation {
    background: $white;
    position: absolute;
    top: 41px;
    right: 0;
    box-shadow: 0 3px 6px $shadow;
    padding: 0 10px;

    & > .main-navigation-item {
      display: table;
      margin: 20px 10px;
    }
  }
</style>

<template>
  <nav class="main-navigation"
       v-on-clickaway="closeOverflow">
    <router-link
      v-for="item in navigation"
      class="main-navigation-item"
      v-on:click.native="closeOverflow"
      :to="item.route"
      :key="item.route"
    >
      {{item.text}}
    </router-link>
    <a ref="showMore" class="show-more" v-on:click="toggleOverflow" v-show="overflowExists">
      Mehr
      <font-awesome-icon v-if="!overflowShown" icon="caret-down"/>
      <font-awesome-icon v-if="overflowShown" icon="caret-up"/>
    </a>
    <nav ref="overflowNavigation"
         class="overflow-navigation"
         v-show="overflowShown"></nav>
  </nav>
</template>

<script>
import { mixin as clickaway } from 'vue-clickaway';
import navigation from '../../assets/data/navigation.json';

export default {
  name: 'Navigation',
  mixins: [clickaway],
  data() {
    return {
      overflowExists: true,
      overflowShown: false,
      navigation,
    };
  },
  methods: {
    toggleOverflow() {
      this.overflowShown = !this.overflowShown;
    },
    closeOverflow() {
      this.overflowShown = false;
    },
    getNavigationHorizontalPadding() {
      const mainNavigationStyle = window.getComputedStyle(this.$el);
      const navigationPaddingLeft = parseFloat(mainNavigationStyle.paddingLeft);
      const navigationPaddingRight = parseFloat(mainNavigationStyle.paddingRight);
      return navigationPaddingLeft - navigationPaddingRight;
    },
    getNavigationsInnerWidth() {
      const navigationHorizontalPadding = this.getNavigationHorizontalPadding();
      const navigationOuterWidth = this.$el.offsetWidth;
      return navigationOuterWidth - navigationHorizontalPadding;
    },
    getShowMoreWidth() {
      const showMoreNode = this.$refs.showMore;
      return showMoreNode.offsetWidth;
    },
    getUseableNavigationWidth() {
      const navigationInnerWidth = this.getNavigationsInnerWidth();
      const showMoreWidth = this.getShowMoreWidth();
      return navigationInnerWidth - showMoreWidth;
    },
    getOverflowedItems(spareNavigationWidth) {
      const roundingBuffer = 10;
      const navigationItems = this.$el.getElementsByClassName('main-navigation-item');
      let accumulatedWidth = 0;
      const overflowNavigationElements = [];
      // eslint-disable-next-line no-restricted-syntax
      for (const entry of navigationItems) {
        accumulatedWidth += entry.offsetWidth + roundingBuffer;
        if (accumulatedWidth > spareNavigationWidth) {
          overflowNavigationElements.push(entry);
        }
      }
      return overflowNavigationElements;
    },
    addToOverflowNavigation(overflowNavigationElements) {
      const { overflowNavigation } = this.$refs;
      overflowNavigationElements.forEach((offsetElement) => {
        overflowNavigation.appendChild(offsetElement);
      });
      this.overflowExists = overflowNavigation.childNodes.length > 0;
    },
    updateNavigation() {
      const spareNavigationWidth = this.getUseableNavigationWidth();
      const overflowNavigationElements = this.getOverflowedItems(spareNavigationWidth);
      this.addToOverflowNavigation(overflowNavigationElements);
    },
  },
  mounted() {
    window.addEventListener('resize', () => {
      this.updateNavigation();
    });

    this.updateNavigation();
  },
};
</script>
