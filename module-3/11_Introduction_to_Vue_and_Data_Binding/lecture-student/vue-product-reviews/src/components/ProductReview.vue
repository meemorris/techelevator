<template>
  <div class="main">
    <h2>Product Reviews for {{ name }}</h2>
    <p class="description">{{ description }}</p>

    <div class="well-display">
      <div class="well">
        <span class="amount">{{averageRating}}</span>
        Average Rating
      </div>

      <div class="well">
        <span class="amount">{{numberOfOneStarReviews}}</span>
        1 Star Review{{numberOfOneStarReviews === 1 ? '' : 's'}}
      </div>

      <div class="well">
        <span class="amount">{{numberOfTwoStarReviews}}</span>
        2 Star Review{{numberOfTwoStarReviews === 1 ? '' : 's'}}
      </div>

      <div class="well">
        <span class="amount">{{numberOfThreeStarReviews}}</span>
        3 Star Review{{numberOfThreeStarReviews === 1 ? '' : 's'}}
      </div>

      <div class="well">
        <span class="amount">{{numberOfFourStarReviews}}</span>
        4 Star Review{{numberOfFourStarReviews === 1 ? '' : 's'}}
      </div>

      <div class="well">
        <span class="amount">{{numberOfFiveStarReviews}}</span>
        5 Star Review{{numberOfFiveStarReviews === 1 ? '' : 's'}} 
        <!-- question mark, what to do if it is true, what to do if it is false, after the colon -->
        <!-- you can't use an if statement, so you can use this conditional expression -->
      </div>
    </div>

    <!-- every element in the for loop needs to be uniquely identified and bound to a key -->
    <!-- I want the index to use as the key, as an internative, I could've said <v-for="review in reviews" v-bind:key="review.reviewer"
      if reviewers were only allowed to do 1 review, the key must uniquely identify the review -->
    <!-- what the v-for is on, is what element gets created for every review -->
    <div class="review" v-for="(review, index) in reviews" v-bind:key="index" v-bind:class="{favorited: review.favorited}">
      <h4>{{ review.reviewer }}</h4>

      <!-- putting a title on the img element when you hover over it -->
      <div class="rating">
          <!-- v-bind if it is not being displayed, curly braces if it is, for one way data binding -->
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
      <p>Favorite? <input type="checkbox" v-model="review.favorited"/></p>
      <!-- v-model is for two-way data binding, not v-bind, which is for one-way data binding -->
    </div>
  </div>
</template>

<script>
export default {
  name: "product-review",
  data() {
    return {
      name: "Cigar Parties for Dummies",
      description:
        "Host and plan the perfect party for all your squirrelly friends",
      reviews: [
        {
          reviewer: "Zac",
          title: "What a book",
          review: "This book changed my life",
          rating: 4,
          favorited: true
        },
        {
          reviewer: "Jonathan",
          title: "Bleh",
          review: "What a stupid book",
          rating: 1,
          favorited: false
        },
      ],
    };
  },
  computed: {
      averageRating() {
          //use reduce to get the total of all of the ratings
          //this refers to the data, that's how you access it
          //currentSum is the accumulator, review is what she is naming each one
          let sum = this.reviews.reduce((currentSum, review) => {
              return currentSum + review.rating; //this will loop through and add the review.rating to the sum
          },0);

          //to get the average, divide by the number of reviews
          return (sum / this.reviews.length).toFixed(1); //the number of reviews in the array
      },
      numberOfOneStarReviews() {
          return this.reviews.reduce((currentCount, review) => {
              return currentCount + (review.rating === 1); //true returns 1, false returns 0 - javascript magicy let count = 1, do a foreach loop, if that review.rating = 1, add that to the count
          },0);
      },
      numberOfTwoStarReviews() {
          return this.reviews.reduce((currentCount, review) => {
              return currentCount + (review.rating === 2); //true returns 1, false returns 0 - javascript magicy let count = 1, do a foreach loop, if that review.rating = 1, add that to the count
          },0);
      },
      numberOfThreeStarReviews() {
          return this.reviews.reduce((currentCount, review) => {
              return currentCount + (review.rating === 3); //true returns 1, false returns 0 - javascript magicy let count = 1, do a foreach loop, if that review.rating = 1, add that to the count
          },0);
      },
      numberOfFourStarReviews() {
          return this.reviews.reduce((currentCount, review) => {
              return currentCount + (review.rating === 4); //true returns 1, false returns 0 - javascript magicy let count = 1, do a foreach loop, if that review.rating = 1, add that to the count
          },0);
      },
      numberOfFiveStarReviews() {
          return this.reviews.reduce((currentCount, review) => {
              return currentCount + (review.rating === 5); //true returns 1, false returns 0 - javascript magicy let count = 1, do a foreach loop, if that review.rating = 1, add that to the count
          },0);
      }
  }
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