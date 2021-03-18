let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Almond Milk', completed: false },
  { id: 3, name: 'Papaya', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Chicken Sausage', completed: false },
  { id: 6, name: 'Eggs', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Spinach', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

function markComplete(li) {
  li.classList.add('completed');
  const iconElement = li.querySelector('i');
  iconElement.classList.add('completed');
}

function markIncomplete(li) {
  li.classList.remove('completed');
  const iconElement = li.querySelector('i');
  iconElement.classList.remove('completed');
}

document.addEventListener('DOMContentLoaded', () => {
  setPageTitle();
  displayGroceries();


  //Mark item complete or mark item incomplete
  const liElements = document.querySelectorAll('li');

  liElements.forEach((element) => {
    element.addEventListener('click', (event) => { //event.target gives you what was clicked on
      if (!event.target.classList.contains('completed')) {
        markComplete(event.target);
      }

      if (event.detail === 2 && event.target.classList.contains('completed')) {
        markIncomplete(event.target);
      }
    });
  });

  //Mark all complete or mark all incomplete
  const toggleAllBtn = document.getElementById('toggleAll');

  toggleAllBtn.addEventListener('click', (event) => {
    if (allItemsIncomplete) {
      liElements.forEach((element) => {
      markComplete(element);
      toggleAllBtn.innerText = 'Mark All Incomplete';  
      allItemsIncomplete = false;
      })
    } else {
      liElements.forEach((element) => {
        markIncomplete(element);
        toggleAllBtn.innerText = 'Mark All Complete';
        allItemsIncomplete = true;
      });
    }
  });

});
