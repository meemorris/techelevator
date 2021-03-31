<template>
  <div>
    <div class="loading" v-if="isLoading">
      <img src="@/assets/ping_pong_loader.gif" />
    </div>
    <div v-else>
      <h1>{{ card.title }}</h1>
      <p>{{ card.description }}</p>
      <comments-list v-bind:comments="card.comments" />
      <div class="board-actions">
        <!--Link to go back to the board page-->
        <router-link 
           v-bind:to="{ name: 'Board',params: {id: $route.params.boardID}}">
           Back to Board
        </router-link>

      </div>
    </div>
  </div>
</template>

<script>
import boardService from "@/services/BoardService.js";
import CommentsList from "@/components/CommentsList.vue";

export default {
  name: "card-detail",
  data() {
    return {
      card: {
        title: "",
        description: "",
        status: "",
        comments: [],
      },
      isLoading: true,
    };
  },
  created() {
    boardService
      .getCard(this.$route.params.boardID, this.$route.params.cardID)
      .then((cardFromResponse) => {
        this.card = cardFromResponse;
        this.isLoading = false;
      });
     
  },
  components: {
    CommentsList,
  },
};
</script>
