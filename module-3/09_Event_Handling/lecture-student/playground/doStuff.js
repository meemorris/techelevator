function demoPreviousElementSibling() {
    const buttonOne = document.getElementById('button-one');
    const prevElementSibling = buttonOne.previousElementSibling;
    prevElementSibling.innerText = 'Previous element sibling to button 1';
    const nextElementSib = buttonOne.nextElementSibling;
    nextElementSib.innerText='Next element sibling to button 1';
}

function checkTheCheckBoxAndEnterText(event) {
    const cb = document.querySelector('div input');
    cb.checked = true;
    //set the next element to ave matching text to the button
    cb.nextElementSibling.value = event.target.innerText;
    // this will prevent the div from turning green
    // event.stopPropagation();
}

function makeBackgroundGreen(currentTarget, target) {
    currentTarget.classList.add('greenBackground');
    alert('you originally clicked on ' + target.innerText);
}

// function checkTheCheckBoxAndEnterText() {
//     const cb = document.querySelector('div input');
//     cb.checked = true;
//     cb.nextElementSibling.value = 'I LOVE JAVASCRIPT';
// }

function forbidden(event) {
    alert('you must stay on this page!');
    event.preventDefault();
}

/* make a listener so that when a user licks the pushme button we call
checkTheCheckBoxAndEnterText */

// get the button
const pushMeButton = document.getElementById('button-one');
//no parens after method name means that the event object is passed as 
//param automatically
pushMeButton.addEventListener('click', checkTheCheckBoxAndEnterText);

//when you click on the don't push me button, change its text color to yellow

//using an anonymous function to add the class makeTextYellow in the event target
const dontPushMe = document.getElementById('button-two');
dontPushMe.addEventListener('click', (event) => event.target.setAttribute('class','makeTextYellow'));

//anytime anyone clicks anywere in the button div, change the background to green

//if a user clicks a button on the dive, this listener will pick it up because it propagates
//the button that was clicked will still be the target, but this dive that's listening is
//going to be the current target
const buttonDiv = document.getElementById('buttons');
buttonDiv.addEventListener('click', (event) => makeBackgroundGreen(event.currentTarget, event.target));

//prevent user from following any links
document.querySelectorAll('a').forEach((link) => link.addEventListener('click', forbidden));

