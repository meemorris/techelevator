// add pageTitle
const pageTitle = 'My Shopping List';

// add groceries
const groceries = ['eggs','oat milk','papaya','apple chicken sausage', 'chicken','limes',
'basil','walnuts','pasta', 'garlic'];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const titleElement = document.getElementById('title');
  titleElement.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  for (let n = 0; n < groceries.length; n++) {
    const ulElement = document.getElementById('groceries');
    const listElement = document.createElement('li');
    listElement.innerText = groceries[n];
    ulElement.appendChild(listElement);
  }
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  const ulElement = document.getElementById('groceries');
  const liElements = ulElement.querySelectorAll('li');

  for (let n = 0; n < liElements.length; n++) {
    liElements[n].setAttribute('class','completed');
  }
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
