<template>
  <div>
      <h1> {{post.author}}</h1>
      <h2> {{post.summary}}</h2>
      <img vind-bind:src="post.pic"/>
      <p> {{post.post}} </p>
  </div>
</template>

<script>
export default {
    name: 'blog-details',
    props: ['post']

}
</script>

<style>

</style>