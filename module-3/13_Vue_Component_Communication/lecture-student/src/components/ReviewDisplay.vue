<template>
  <div class="review" v-bind:class="{ favorited: review.favorited }" v-bind:key="review.id">
    <h4>{{ review.reviewer }}</h4>
    <div class="rating">
      <img
        src="../assets/star.png"
        v-bind:title="review.rating + ' Star Review'"
        class="ratingStar"
        v-for="n in review.rating"
        v-bind:key="n"
      />

      <!-- for every review in this component, it will create a component -->
    </div>
    <h3>{{ review.title }}</h3>
    <p>{{ review.review }}</p>
    <p>
      Favorite?
      <input
        type="checkbox"
        v-on:change="onFavoritedChange"
        v-bind:checked="review.favorited"
      />
      <!-- if the data says it is favorited, check the box -->
      <!-- if someone checks the box we will do it using a mutation -->
      <!-- we don't use v-model because we only want changing to happen on a mutation -->
    </p>
  </div>
</template>

<script>
export default {
  name: "review-display",
  props: ["review"],
  methods: {
    onFavoritedChange() {
      this.$store.commit("FLIP_FAVORITED", this.review);
    }
  }
};
</script>

<style>
div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main div.review.favorited {
  background-color: lightyellow;
}

div.main div.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main div.review div.rating img {
  height: 100%;
}

div.main div.review p {
  margin: 20px;
}

div.main div.review h3 {
  display: inline-block;
}

div.main div.review h4 {
  font-size: 1rem;
}
</style>
