<template>
  <div id="app">
    <main-fan-blog topic="How Much We All Love Vue"/>

  </div>
</template>

<script>
import MainFanBlog from './components/MainFanBlog.vue'

export default {
  name: 'App',
  components: {
    MainFanBlog
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
