<template>
  <div class="book-container">
    <router-link class="links"
    v-for="book in $store.state.books" v-bind:key="book.isbn"
    v-bind:to="{ name: 'book-detail', params: { isbn: book.isbn}}"
    >
    <book-card v-bind:book="book"  />
    </router-link>
  </div>
</template>

<script>
import BookCard from '@/components/BookCard.vue';

export default {
    name: 'reading-list',
    components: {
        BookCard
    }
}
</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}

.links {
  text-decoration: none;
  color: rgb(63, 60, 60);
}

.links:hover {
  color: rgb(12, 143, 132);
}
</style>