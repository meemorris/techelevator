<template>
  <div class="products">
      <h1>Products</h1>
      <products-list />
  </div>
</template>

<script>
import ProductsList from'@/components/ProductsList.vue' 
// @ means start at src
export default {
    components: {
        ProductsList
    }
}
</script>

<style>

</style>