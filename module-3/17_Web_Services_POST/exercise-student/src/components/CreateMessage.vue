<template>
  <form v-on:submit.prevent>
    <div class="field">
      <div class="status-message error" v-show="errorMsg !== ''">{{errorMsg}}</div>
      <label for="title">Title</label>
      <input type="text" name="title" v-model="message.title" />
    </div>
    <div class="field">
      <label for="messageText">Message</label>
      <input type="text" name="messageText" v-model="message.messageText" />
    </div>
    <div class="actions">
      <button type="submit" v-on:click="saveMessage()">Save Message</button>
    </div>
  </form>
</template>

<script>
import messageService from "../services/MessageService";

export default {
  name: "create-message",
  props: ["topicId"],
  data() {
    return {
      message: {
        id: Math.floor(Math.random() * (1000 - 100) + 100),
        topicId: this.topicId,
        title: "",
        messageText: ""
      },
      errorMsg: ''
    };
  },
  methods: {
    saveMessage() {
      messageService.create(this.message)
      .then((response) => {
        if (response && response.status === 201) {
          this.$router.push(`/${this.message.topicId}`);
        }
      })
      .catch(error => {
        if (error.response) {
          this.errorMsg = "Error adding new message. Response was " + error.response.statusText;
        } else if (error.request) {
          this.errorMsg = "Error adding new message. Unreachable server."
        } else {
          this.errorMsg = "Error adding new message. Could not create request."
        }
      })
    }
  }
};
</script>

<style>
</style>
