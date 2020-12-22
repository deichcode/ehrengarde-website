<style scoped lang="scss">
  .socialMediaContainer{
    display: flex;
    flex-direction: row;
   justify-content: space-around;
  };

  .socialMediaItem{
    font-size: 2em;
    color: white;
  };
</style>

<template>
  <div class="socialMediaContainer">
  <div class="socialMediaItem">
    <a href="https://www.instagram.com/ehrengardeneuwied/?hl=de">
    <font-awesome-icon :icon="['fab', 'instagram']" class="icon alt"/>
    </a>
  </div>
    <div class="socialMediaItem">
      <a href="https://de-de.facebook.com/Ehrengarde.Neuwied/">
      <font-awesome-icon :icon="['fab', 'facebook']" class="icon alt}" />
      </a>
    </div>
  <div class="socialMediaItem">
    <a href="https://twitter.com/ehrengarde_nwd?lang=de">
    <font-awesome-icon :icon="['fab', 'twitter']" class="icon alt"/>
    </a>
  </div>
</div>
</template>

<script>
  export default {
    name: 'SocialMedia',
  };
</script>
