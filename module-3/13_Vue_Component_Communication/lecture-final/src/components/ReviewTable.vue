<template>
<table>
    <thead>
      <tr>
        <th>Title</th>
        <th>Reviewer</th>
        <th>Review</th>
        <th>Rating</th>
        <th>Favorited</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="review in filteredReviews" v-bind:key="review.title">
        <td>{{ review.title }}</td>
        <td nowrap>{{ review.reviewer }}</td>
        <td>{{ review.review }}</td>
        <td class="stars">
          <img
            src="../assets/star.png"
            v-bind:title="review.rating + ' Star Review'"
            class="star"
            v-for="n in review.rating"
            v-bind:key="n"
            width="20px"
          />
        </td>
        <td>
          <input
            type="checkbox"
            v-bind:checked="review.favorited"
            v-on:change="onFavoritedChange(review)"
          />
        </td>
      </tr>
      <tr v-show="filteredReviews.length == 0">
        <td colspan="5">There are no reviews</td>
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
  name: "review-table",
  computed: {
    filteredReviews() {
      const reviewsFilter = this.$store.state.filter;
      const reviews = this.$store.state.reviews;
      return reviews.filter(review => {
        return reviewsFilter === 0 ? true : reviewsFilter === review.rating;
      });
    }
  },
  methods: {
    onFavoritedChange(review){
      this.$store.commit("FLIP_FAVORITED",review);
    }
  }
};
</script>

<style style="scoped">
th,
td {
  text-align: left;
}
td {
  padding-right: 10px;
  vertical-align: top;
}
tr:nth-child(even) {
  background-color: rgb(238, 238, 238);
}
.stars {
  display: flex;
}
</style>
