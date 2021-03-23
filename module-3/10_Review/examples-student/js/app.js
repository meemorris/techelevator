
const htmlText = '<p> hey <em> this is html</em>  </p>';

document.addEventListener('DOMContentLoaded', () => {

  //grab the divs and set the text
  const useText = document.getElementById('useInnerText');
  useText.innerText=htmlText;

  const useHTML = document.getElementById('useInnerHTML');
  useHTML.innerHTML=htmlText;

  const colorButton = document.getElementById('changeTheColor')
  colorButton.addEventListener('click', changeColor) //no parens, javascript sends in the event as the parameter

  const addAnother = document.getElementById('addLI')
  addAnother.addEventListener('click', () => {
    wtf()
    const addDiv = document.getElementById('listAddDiv')
    addDiv.classList.remove('d-none')
    const addBtn = addDiv.querySelector('button')
    addBtn.addEventListener('click', addNameToList)
  })

  const theList = document.getElementById('theList') //event delegation - this way when a new LI element is added the event listener will still catch events because it bubbles up
  //event delegation - put it on the parent, handle all the clicks of your children
  theList.addEventListener('click', (event) => {
    if (event.target.innerText == 'Katie') { //event.target shows where they clicked
      alert('great answer!')
    } else {
      wtf();
    }
  })

  //propagation
  const propDivs = document.querySelectorAll('div.prop')
  propDivs.forEach((div) => div.addEventListener('click', showPropMsg))
})

function showPropMsg(event) {
  let detectedAt = event.target.getAttribute('id') //event.target is where they clicked
  if(detectedAt==null ) { //if the click was on the p, get the id from the parent (div)
    detectedAt =  event.target.parentElement.getAttribute('id') //get the id from the parent element
  }
  
  const paraToUpdate = event.currentTarget.querySelector('p') 
  paraToUpdate.innerText = paraToUpdate.innerText + 
    ' CLICK DETECTED HERE: ' +
    detectedAt + '!  '
    
  if (event.target.classList.contains('noprops')){
    event.stopPropagation()
  }
}

function addNameToList() {
  const theList = document.getElementById('theList')
  const theOther = document.createElement('li')
  theOther.innerText = document.getElementById('fname').value
  theList.appendChild(theOther)
  const addDiv = document.getElementById('listAddDiv')
  addDiv.classList.add('d-none')
}

function wtf() {
  alert('wtf?!?')
}

function changeColor(event) {
  let random = Math.random(); //returns a random number between 0 and 1
  let colorClass = 'blue';
  if (random < .2) {
    colorClass = 'green';
  } else if (random < .4) {
    colorClass = 'pink';
  } else if (random < .6) {
    colorClass = 'purple';
    event.target.removeEventListener('click', changeColor)
    const theText = document.querySelector('div#colorChanger p')
    theText.innerText = 'I like purple. Button is no longer listening.'
    theText.classList.add('bigFont')
  } else if (random < .8) {
    colorClass = 'red';
  } else if (random < .9) {
    colorClass = 'yellow';
  }
  document.getElementById('colorChanger').setAttribute('class', colorClass)
}