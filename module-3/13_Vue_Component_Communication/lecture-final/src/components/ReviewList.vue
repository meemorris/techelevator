<template>
  <div class="reviews">
    <!--here v-bind:review the v-bind is required since review is an object not a string-->
    <review-display
      v-for="reviewItem in filteredReviews"
      v-bind:key="reviewItem.title"
      v-bind:review="reviewItem" 
    />
  </div>
</template>

<script>
import ReviewDisplay from "./ReviewDisplay";

export default {
  name: "review-list",
  components: {
    ReviewDisplay
  },
  computed: {
    filteredReviews() {
      const reviewsFilter = this.$store.state.filter;
      const reviews = this.$store.state.reviews;
      return reviews.filter(review => {
        return reviewsFilter === 0 ? true : reviewsFilter === review.rating;
      });
    }
  }
};
</script>

<style>
div.main {
  margin: 1rem 0;
}
div.main div.well-display {
  display: flex;
  justify-content: space-around;
}

div.main div.well-display div.well {
  display: inline-block;
  width: 15%;
  border: 1px black solid;
  border-radius: 6px;
  text-align: center;
  margin: 0.25rem;
}

div.main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}

div.main div.well-display div.well {
  cursor: pointer;
}
</style>
