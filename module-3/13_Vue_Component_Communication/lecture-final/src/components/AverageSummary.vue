<template>
  <div class="well">
    <span class="amount" v-on:click="updateFilter()">{{ averageRating }}</span>
    Average Rating
  </div>
</template>

<script>
export default {
  name: "average-summary",
  methods: {
    updateFilter() {
      this.$store.commit("UPDATE_FILTER", 0);
      //this.$store.state.filter =0; don't update datastore without a mutation

    }
  },
  computed: {
    averageRating() {
      const reviews = this.$store.state.reviews;
      let sum = reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);
      return (sum / reviews.length).toFixed(2);
    }
  }
};
</script>
