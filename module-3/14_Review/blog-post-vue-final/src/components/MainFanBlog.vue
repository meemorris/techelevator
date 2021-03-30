<template>
  <div>
      <h1> Welcome to the blog post page, where we talk all about {{topic}} </h1>
      <blog-list />
  </div>
</template>

<script>
import BlogList from './BlogList.vue'

export default {
    name: 'main-fan-blog',
    props: ['topic'],
    components: {
        BlogList
    }

}
</script>

<style>

</style>