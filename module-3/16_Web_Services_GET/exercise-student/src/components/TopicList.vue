<template>
  <div class="topic-list">
    <router-link class="links"
    v-for="topic in topics" v-bind:key="topic.id"
    v-bind:to="{ name: 'Messages', params: {id: topic.id}}"
    >
    <div class="topic">
      {{ topic.title }}
    </div>
    </router-link>
  </div>
</template>

<script>
import topicsService from '@/services/TopicsService.js'
export default {
  name: 'topic-list',
  data() {
    return {
      topics: []
    }
  },
  created() {
    topicsService.getTopics().then(response => {
      this.topics = response.data;
    })
  }
}
</script>

<style>

.topic-list {
  padding: 20px 20px;
  margin: 0 auto;
  max-width: 600px;
}
.topic {
  font-size: 24px;
  border-bottom: 1px solid #e2e2e2;
  padding: 10px 20px;
}
.topic:last-child {
  border: 0px;
}
.links {
  text-decoration: none;
  color: hsl(165, 50%, 47%);
}

a:hover {
  color: #2c3e50;
}

</style>