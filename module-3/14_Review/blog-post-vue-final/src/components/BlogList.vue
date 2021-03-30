<template>
  <div>
    <div
      class="blogPost"
      v-for="(post, index) in allThePosts"
      v-bind:key="index"
      v-on:click="showPostDetails = post"
      v-on:dblclick="deleteThePost(index)"
    >
      <h2>Read {{ post.author }} talk all about {{ post.summary }}</h2>
    </div>
    <blog-details v-if="showPostDetails.author" v-bind:post="showPostDetails" />
  </div>
</template>

<script>
import BlogDetails from "./BlogDetails.vue";
export default {
  name: "blog-list",
  data() {
    return {
      showPostDetails: {},
    };
  },
  computed: {
    allThePosts() {
      return this.$store.state.blogPosts;
    },
  },
  components: {
    BlogDetails,
  },
  methods: {
      deleteThePost(index) {
          if (confirm('This is permanent. Are you sure you want to continue?')) {
              this.$store.commit("DELETE_POST",index);
              this.showPostDetails={};
          }
      }
  }
};
</script>

<style scoped>
div.blogPost {
  border: 2px solid black;
}
</style>