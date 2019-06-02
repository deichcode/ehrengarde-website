module.exports = {
  css: {
    loaderOptions: {
      sass: {
        data: `
          @import "@/styles/colors.scss";
          @import "@/styles/fonts.scss";
          @import "@/styles/variables.scss";
          @import "@/styles/style.scss";
        `,
      },
    },
  },
};
