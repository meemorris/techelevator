<template>
  <div class="main">
    <h2>Product Reviews for {{ name }}</h2>
    <p class="description">{{ description }}</p>
    <div class="well-display">
      <div class="well">
        <span class="amount">{{ averageRating }}</span>
        Average Rating
      </div>

      <div class="well">
        <span class="amount">{{ numberOfOneStarReviews }}</span>
        1 Star Review{{numberOfOneStarReviews===1?'':'s'}}
      </div>

      <div class="well">
        <span class="amount">{{ numberOfTwoStarReviews }}</span>
        2 Star Review{{numberOfTwoStarReviews===1?'':'s'}}
      </div>

      <div class="well">
        <span class="amount">{{ numberOfThreeStarReviews}}</span>
        3 Star Review{{numberOfThreeStarReviews===1?'':'s'}}
      </div>

      <div class="well">
        <span class="amount">{{ numberOfFourStarReviews}}</span>
        4 Star Review{{numberOfFourStarReviews===1?'':'s'}}
      </div>

      <div class="well">
        <span class="amount">{{ numberOfFiveStarReviews}}</span>
        5 Star Review{{numberOfFiveStarReviews===1?'':'s'}}
      </div>
    </div>

    <!-- I want the index to use as the key, as an alternative,
           I could've said <v-for="review in reviews" v-bind:key="review.reviwer"
           if reviwers were only allowd to do 1 review. The key must uniquely identify
           the review -->
    <div class="review" v-for="(review, index) in reviews" v-bind:key="index" v-bind:class="{favorited: review.favorited}">
      <h4>{{ review.reviewer }}</h4>

      <div class="rating">
        <img
          src="../assets/star.png"
          v-for="n in review.rating"
          v-bind:key="n"
          class="ratingStar"
          v-bind:title="review.rating + ' Star Review'"
        />
      </div>

      <h3>{{ review.title }}</h3>
      <p>{{ review.review }}</p>
      <p>Favorite? <input type="checkbox" v-model="review.favorited" /> </p>
    </div>
  </div>
</template>

<script>
export default {
  name: "product-review",
  data() {
    return {
      name: "Cigar Parties for Dummies",
      description: "Host and plan the perfect party",
      reviews: [
        {
          reviewer: "Zac",
          title: "What a book",
          review: "This book changed my life",
          rating: 2,
          favorited: true
        },
        {
          reviewer: "Jonathan",
          title: "Bleh",
          review: "what a stupid book",
          rating: 1,
        },
      ],
    };
  },
  computed: {
    averageRating() {
      //use reduce to get the total of all of the ratings
      let sum = this.reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);

      //divide by the number of reviews
      return (sum / this.reviews.length).toFixed(1);
    },
    numberOfOneStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 1);
      }, 0);
    },
    numberOfTwoStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 2);
      }, 0);
    },
    numberOfThreeStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 3);
      }, 0);
    },
    numberOfFourStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 4);
      }, 0);
    },
    numberOfFiveStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 5);
      }, 0);
    },
  },
};
</script>

<style scoped>
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

div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
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
div.main div.review.favorited {
    background-color: lightyellow;
}
</style>