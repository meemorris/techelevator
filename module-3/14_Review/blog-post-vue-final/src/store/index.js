import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    blogPosts: [
      {
        author: "katie",
        summary: "cool",
        pic: "",
        post: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
      },
      {
        author: "megan",
        summary: "vue is great",
        pic: "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic01.nyt.com%2Fimages%2F2018%2F05%2F03%2Fus%2F03spongebob_xp%2F03spongebob_xp-videoSixteenByNineJumbo1600.jpg&imgrefurl=https%3A%2F%2Fwww.nytimes.com%2F2019%2F05%2F01%2Farts%2Fspongebob-squarepants-stephen-hillenburg.html&tbnid=SCgbk7SWVaizhM&vet=12ahUKEwjLyOWylM7vAhUMg6wKHetAD2AQMygBegUIARDNAQ..i&docid=scpZlyiQJrXneM&w=1600&h=900&q=spongebob%20image&ved=2ahUKEwjLyOWylM7vAhUMg6wKHetAD2AQMygBegUIARDNAQ",
        post: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
      },
      {
        author: "Dom",
        summary: "review sessions rule",
        pic: "",
        post: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
      },
      {
        author: "Dan",
        summary: "i love front end",
        pic: "",
        post: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
      },

    ]
  },
  mutations: {
    DELETE_POST(state,index){
      state.blogPosts.splice(index,1);
    },
    DELETE_AUTHOR_POST(state,author){
      state.blogPosts = state.blogPosts.filter(post=>{return post.author!= author})
    }
  },
  actions: {
  },
  modules: {
  }
})
