<template>
  <book-details v-bind:book="book"/>
</template>

<script>
import BookDetails from '@/components/BookDetails.vue'
//this one should have the route parameters
//have this one  figure out the book and then pass it into book details as a prop
export default {
    name: 'book-detail',
    components: {
        BookDetails
    },
    computed: {
        book() {
            return this.$store.state.books.find(
                book => book.isbn == this.$route.params.isbn
            );
        }
    }

}
</script>

<style>

</style>