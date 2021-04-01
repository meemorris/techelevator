<template>
  <div id="app" class="main">
    <h1>{{ product.name }}</h1>
    <p class="description">{{ product.description }}</p>
    <div class="actions">
        <router-link v-bind:to="{name: 'products'}">Back to Products</router-link>&nbsp;|
        <!-- if putting in just the hardcoded path, just use the to attribute, don't need to use v-bind -->
        <!-- <router-link to="/">Back to Products</router-link>&nbsp;| (not best practice to use the path, try to use the name)-->
      <!-- <a href="#">Back to Products</a>&nbsp;| -->
      <router-link v-bind:to="{name: 'add-review', params: {id:product.id}}">
          Add Review
      </router-link>
      <!-- <a href="#">Add Review</a> -->
    </div>
    <div class="well-display">
      <average-summary />
      <star-summary rating="1" />
      <star-summary rating="2" />
      <star-summary rating="3" />
      <star-summary rating="4" />
      <star-summary rating="5" />
    </div>
    <review-list />
  </div>
</template>

<script>
import AverageSummary from '@/components/AverageSummary.vue'
import StarSummary from '@/components/StarSummary.vue'
// import AddReview from '@/components/AddReview.vue'
import ReviewList from '@/components/ReviewList.vue'

export default {
    //lifecycle hook that will be executed every time this component is created
    created() {
        const activeProductId = this.$route.params.id;
        this.$store.commit("SET_ACTIVE_PRODUCT", activeProductId);
    },
    computed: {
        product() {
            return this.$store.state.products.find(
                p => p.id == this.$store.state.activeProduct
            );

            //could use v-if and v-else and just display an error if you use v-else
            //let foundProduct
            // if (foundProduct) {
            //     return foundProduct
            // }
            // foundProduct = {name: 'Not Found', description:'', reviews:[]};
            // return foundProduct;
        }
    },
    components: {
        AverageSummary,
        StarSummary,
        ReviewList
    }

}
</script>

<style>

</style>