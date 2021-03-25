<template>
  <div class="container">
    <table id="tblUsers">
      <thead>
        <tr>
          <th>&nbsp;</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Username</th>
          <th>Email Address</th>
          <th>Status</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>
            <input
              type="checkbox"
              id="selectAll"
              v-bind:checked = "selectedUserIDs.length == users.length"
              v-on:click="selectAll"/>
          </td>
          <td>
            <input
              type="text"
              id="firstNameFilter"
              v-model="filter.firstName"
            />
          </td>
          <td>
            <input type="text" id="lastNameFilter" v-model="filter.lastName" />
          </td>
          <td>
            <input type="text" id="usernameFilter" v-model="filter.username" />
          </td>
          <td>
            <input type="text" id="emailFilter" v-model="filter.emailAddress" />
          </td>
          <td>
            <select id="statusFilter" v-model="filter.status">
              <option value>Show All</option>
              <option value="Active">Active</option>
              <option value="Disabled">Disabled</option>
            </select>
          </td>
          <td>&nbsp;</td>
        </tr>
        <tr
          v-for="user in filteredList"
          v-bind:key="user.id"
          v-bind:class="{ disabled: user.status === 'Disabled' }"
        >
          <td>
            <input
              type="checkbox"
              v-bind:id="user.id"
              v-bind:value="user.id"
              name="selectedUserIDs"
              v-model="selectedUserIDs"
            />
          </td>
          <td>{{ user.firstName }}</td>
          <td>{{ user.lastName }}</td>
          <td>{{ user.username }}</td>
          <td>{{ user.emailAddress }}</td>
          <td>{{ user.status }}</td>
          <td>
            <button class="btnEnableDisable" v-on:click="flipStatus(user.id)">
              {{ user.status === "Active" ? "Disable" : "Enable" }}
            </button>
          </td>
        </tr>
      </tbody>
    </table>

    <div class="all-actions">
      <button
        v-bind:disabled="actionButtonDisabled"
        v-on:click="enableSelectedUsers"
      >
        Enable Users
      </button>

      <button
        v-bind:disabled="actionButtonDisabled"
        v-on:click="disableSelectedUsers"
      >
        Disable Users
      </button>

      <button
        v-bind:disabled="actionButtonDisabled"
        v-on:click="deleteSelectedUsers"
      >
        Delete Users
      </button>
    </div>

    <button v-on:click="showForm = true">Add New User</button>

    <form id="frmAddNewUser" v-show="showForm === true">
      <div class="field">
        <label for="firstName">First Name:</label>
        <input type="text" name="firstName" v-model="newUser.firstName" />
      </div>
      <div class="field">
        <label for="lastName">Last Name:</label>
        <input type="text" name="lastName" v-model="newUser.lastName" />
      </div>
      <div class="field">
        <label for="username">Username:</label>
        <input type="text" name="username" v-model="newUser.username" />
      </div>
      <div class="field">
        <label for="emailAddress">Email Address:</label>
        <input type="text" name="emailAddress" v-model="newUser.emailAddress" />
      </div>
      <button type="submit" class="btn save" v-on:click.prevent="saveUser">
        Save User
      </button>
    </form>
  </div>
</template>

<script>
export default {
  name: "user-list",
  data() {
    return {
      filter: {
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "",
      },
      newUser: {
        id: null,
        firstName: "",
        lastName: "",
        username: "",
        emailAddress: "",
        status: "Active",
      },
      showForm: false,
      selectedUserIDs: [],
      users: [
        {
          id: 1,
          firstName: "John",
          lastName: "Smith",
          username: "jsmith",
          emailAddress: "jsmith@gmail.com",
          status: "Active",
        },
        {
          id: 2,
          firstName: "Anna",
          lastName: "Bell",
          username: "abell",
          emailAddress: "abell@yahoo.com",
          status: "Active",
        },
        {
          id: 3,
          firstName: "George",
          lastName: "Best",
          username: "gbest",
          emailAddress: "gbest@gmail.com",
          status: "Disabled",
        },
        {
          id: 4,
          firstName: "Ben",
          lastName: "Carter",
          username: "bcarter",
          emailAddress: "bcarter@gmail.com",
          status: "Active",
        },
        {
          id: 5,
          firstName: "Katie",
          lastName: "Jackson",
          username: "kjackson",
          emailAddress: "kjackson@yahoo.com",
          status: "Active",
        },
        {
          id: 6,
          firstName: "Mark",
          lastName: "Smith",
          username: "msmith",
          emailAddress: "msmith@foo.com",
          status: "Disabled",
        },
      ],
    };
  },
  methods: {
    saveUser() {
      this.users.push(this.newUser);
      this.resetForm();
    },
    resetForm() {
      this.newUser = {};
      this.showForm = false;
    },
    flipStatus(id) {
      this.users.forEach((user) => {
        if (id === user.id) {
          if (user.status === "Disabled") {
            return (user.status = "Active");
          } else {
            return (user.status = "Disabled");
          }
        }
      });
    },
    enableSelectedUsers() {
      for (let n = 0; n < this.selectedUserIDs.length; n++) {
        let userId = this.selectedUserIDs[n];
        let userIndex = this.users.findIndex((user) => user.id == userId);
        this.users[userIndex].status = "Active";
      }
    },
    disableSelectedUsers() {
      for (let n = 0; n < this.selectedUserIDs.length; n++) {
        let userId = this.selectedUserIDs[n];
        let userIndex = this.users.findIndex((user) => user.id == userId);
        this.users[userIndex].status = "Disabled";
      }
      this.selectedUserIDs = [];
    },
    deleteSelectedUsers() {
      for (let n = 0; n < this.selectedUserIDs.length; n++) {
        let userId = this.selectedUserIDs[n];
        let userIndex = this.users.findIndex((user) => user.id == userId);
        this.users.splice(userIndex, 1);
      }
      this.selectedUserIDs = [];
    },
    selectAll() {
      if (document.getElementById("selectAll").checked) {
        this.users.forEach((user) => {
          if (!this.selectedUserIDs.includes(user.id)) {
          this.selectedUserIDs.push(user.id);
          }
        })
      } else {
        this.selectedUserIDs = [];
      }
    }
    // Do not understand why the last 2 tests are not passing 
    //when you use the website, it has all the funtionality described :(
  },
  computed: {
    filteredList() {
      let filteredUsers = this.users;
      if (this.filter.firstName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.firstName
            .toLowerCase()
            .includes(this.filter.firstName.toLowerCase())
        );
      }
      if (this.filter.lastName != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.lastName
            .toLowerCase()
            .includes(this.filter.lastName.toLowerCase())
        );
      }
      if (this.filter.username != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.username
            .toLowerCase()
            .includes(this.filter.username.toLowerCase())
        );
      }
      if (this.filter.emailAddress != "") {
        filteredUsers = filteredUsers.filter((user) =>
          user.emailAddress
            .toLowerCase()
            .includes(this.filter.emailAddress.toLowerCase())
        );
      }
      if (this.filter.status != "") {
        filteredUsers = filteredUsers.filter(
          (user) => user.status === this.filter.status
        );
      }
      return filteredUsers;
    },
    actionButtonDisabled() {
      if (this.selectedUserIDs.length === 0) {
        return true;
      } else {
        return false;
      }
    },
  },
};
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
  margin-bottom: 20px;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}

form {
  margin: 20px;
  width: 350px;
}
.field {
  padding: 10px 0px;
}
label {
  width: 140px;
  display: inline-block;
}
button {
  margin-right: 5px;
}
.all-actions {
  margin-bottom: 40px;
}
.btn.save {
  margin: 20px;
  float: right;
}
</style>
