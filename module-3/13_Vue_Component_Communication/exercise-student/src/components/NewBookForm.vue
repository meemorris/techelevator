<template>
  <form v-on:submit.prevent="addNewBook" class="new-book-form">
    <div class="title-input">
        <label for="title">Title:</label>
        <input type="text" name="title" v-model="newBook.title"/>
    </div>
    <div class="author-input">
        <label for="author">Author:</label>
        <input type="text" name="author" v-model="newBook.author" />
    </div>
    <div class="isbn-input">
        <label for="isbn">ISBN:</label>
        <input type="text" name="isbn" v-model="newBook.isbn"/>
    </div>
    <button type="submit">
        Add Book 
    </button>
  </form>
</template>

<script>
export default {
    data() {
        return {
            newBook: {
                title: '',
                author: '',
                isbn: '',
                read: false
            }
        }
    },
    methods: {
        addNewBook() {
            this.$store.commit("ADD_BOOK", this.newBook);
            this.resetForm();
        },
        resetForm() {
            this.newBook = {read: false};
        }
    }

}
</script>

<style>

</style>