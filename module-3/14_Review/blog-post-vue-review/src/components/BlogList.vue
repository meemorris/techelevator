<template>
  <div>
    <div
      class="blog-post"
      v-for="(post, index) in allThePosts"
      v-bind:key="index"
      v-on:click="showPostDetails = post"
      v-on:dblclick="deleteThePost(index)"
    >
      <h2>Read {{ post.author }} {{ post.summary }}</h2>
    </div>
    <blog-details v-if="showPostDetails.author" v-bind:post="showPostDetails" />
    <!-- show blog details only if the author is filled in for the post, bind the post that is passed to the child to showPostDetails -->
  </div>
</template>

<script>
import BlogDetails from "./BlogDetails.vue";
export default {
  components: { BlogDetails },
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
  methods: {
      deleteThePost(index) {
          if (confirm('This will permanently delete this blog post.')) {
              this.$store.commit("DELETE_POST", index);
              this.showPostDetails = {};
          }
      }
  }
};
</script>

<style scoped>
div.blog-post {
  border: 2px solid black;
  margin-bottom: 5px;
}
</style>