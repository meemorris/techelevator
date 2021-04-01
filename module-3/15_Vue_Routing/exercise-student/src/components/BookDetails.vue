<template>
  <div>
      <h1>{{book.title}}</h1>
      <h2>{{book.author}}</h2>
      <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
      <p>{{ book.read == true ? "I have read this book" : "I have not read this book"}}</p>
  </div>
</template>

<script>

//pass in a book as a prop
export default {
    name: 'book-details',
    props: ['book']
}
</script>

<style>

</style>