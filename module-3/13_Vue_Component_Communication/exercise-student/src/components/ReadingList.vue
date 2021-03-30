<template>
  <div class="book-container">
    <book-card
    v-for="bookItem in $store.state.books"
    v-bind:key="bookItem.title"
    v-bind:book="bookItem"
    v-bind:class="{ 'read' : bookItem.read == true}"
    />

  </div>
</template>

<script>
import BookCard from './BookCard.vue'

export default {
  components: { BookCard },
    name: 'reading-list'
}
</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>