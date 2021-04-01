<template>
  <div>
      <h1>Welcome to the blog post page, where we talk all about {{topic}}</h1>
      <blog-list />
  </div>
</template>

<script>
import BlogList from './BlogList.vue'
export default {
  components: { BlogList },
    name: 'main-fan-blog',
    props: ['topic']
}
</script>

<style>

</style>