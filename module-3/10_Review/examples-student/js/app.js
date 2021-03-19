
const htmlText = '<p> hey <em> this is html</em>  </p>';

document.addEventListener('DOMContentLoaded', () => {

  //grab the divs and set the text
  const useText = document.getElementById('useInnerText');
  useText.innerText=htmlText;

  const useHTML = document.getElementById('useInnerHTML');
  useHTML.innerHTML=htmlText;

  const colorButton = document.getElementById('changeTheColor')
  colorButton.addEventListener('click', changeColor)

  const addAnother = document.getElementById('addLI')
  addAnother.addEventListener('click', () => {
    wtf()
    const addDiv = document.getElementById('listAddDiv')
    addDiv.classList.remove('d-none')
    const addBtn = addDiv.querySelector('button')
    addBtn.addEventListener('click', addNameToList)
  })

  const theList = document.getElementById('theList')
  theList.addEventListener('click', (event) => {
    if (event.target.innerText == 'Katie') {
      alert('great answer!')
    } else {
      wtf();
    }
  })

  const propDivs = document.querySelectorAll('div.prop')
  propDivs.forEach((div) => div.addEventListener('click', showPropMsg))
})

function showPropMsg(event) {
  let detectedAt = event.target.getAttribute('id')
  if(detectedAt==null ) {
    detectedAt =  event.target.parentElement.getAttribute('id')
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
  let random = Math.random();
  let colorClass = 'blue';
  if (random < .2) {
    colorClass = 'green';
  } else if (random < .4) {
    colorClass = 'pink';
  } else if (random < .6) {
    colorClass = 'purple';
    event.target.removeEventListener('click', changeColor)
    const theText = document.querySelector('div#colorChanger p')
    theText.innerHTML = 'I like purple. Button is no longer listening.'
    theText.classList.add('bigFont')
  } else if (random < .8) {
    colorClass = 'red';
  } else if (random < .9) {
    colorClass = 'yellow';
  }
  document.getElementById('colorChanger').setAttribute('class', colorClass)
}