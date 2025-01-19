module.exports = {
  css: {
    loaderOptions: {
      sass: {
        additionalData: `
          @import "@/styles/colors.scss";
          @import "@/styles/fonts.scss";
          @import "@/styles/variables.scss";
          @import "@/styles/global.scss";
          @import "@/styles/mixins.scss";
        `,
      },
    },
  },
  productionSourceMap: false,
  devServer: {
    proxy: {
      '/api': {
        target: 'http://localhost:5000',
        ws: true,
        changeOrigin: true,
      },
    },
  },
  configureWebpack: {
    devtool: 'source-map'
  }
};
