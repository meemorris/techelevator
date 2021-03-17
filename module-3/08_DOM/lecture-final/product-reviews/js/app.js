const productName = 'Cigar Parties for Dummies';
const description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
const reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.",
    rating: 3
  },
  {
    reviewer: 'Tim Ferriss',
    title: 'Had a cigar party started in less than 4 hours.',
    review:
      "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
    rating: 4
  },
  {
    reviewer: 'Ramit Sethi',
    title: 'What every new entrepreneurs needs. A door stop.',
    review:
      "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
    rating: 1
  },
  {
    reviewer: 'Gary Vaynerchuk',
    title: 'And I thought I could write',
    review:
      "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
    rating: 3
  }
];

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  const pageTitle = document.getElementById('page-title');
  pageTitle.querySelector('.name').innerText = productName;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  const descriptionElement = document.querySelector('.description');
  descriptionElement.innerText = description;
}

/* Reviews should look like this    
     <div class="review">
            <h4>Malcolm Gladwell</h4>
            <div class="rating">
                <img src="img/star.png" class="ratingStar"/>
            </div>
            <h3>What a book!</h3>
            <p>It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.</p>
        </div>
        */
/**
 * I will display all of the reviews on the page.
 * I will loop over the array of reviews and use some helper functions
 * to create the elements needed for our markup and add them to the DOM
 */
function displayReviews() {
  const main = document.getElementById('main');
  reviews.forEach( review => {
    const container = document.createElement('div');
    container.setAttribute('class','review');

    //add reviewer, rating, title and review
    addReviewer(container,review.reviewer);
    addRating(container,review.rating);
    addTitle(container,review.title);
    addReview(container,review.review);

    main.insertAdjacentElement('beforeend',container);
  })
}

/**
 * I will creating a new h4 element with the name of the reviewer and append it to
 * the parent element that is passed to me.
 *
 * @param {HTMLElement} el: The element to append the reviewer to
 * @param {string} name The name of the reviewer
 */
function addReviewer(parent, name) {
  const reviewer = document.createElement('h4');
  reviewer.innerText = name;
  parent.appendChild(reviewer);
}

/**
 *  <div class="rating">
                <img src="img/star.png" class="ratingStar"/>
            </div>

 * I will add the rating div along with a star image for the number of ratings 1-5
 * @param {HTMLElement} parent
 * @param {Number} numberOfStars
 */
function addRating(parent, numberOfStars) {
  const rating = document.createElement('div');
  rating.setAttribute('class','rating');
  //create the same number of images as rating
  for(let n=0; n<numberOfStars; n++){
    const star = document.createElement('img');
    star.setAttribute('class','ratingStar');
    star.src = 'img/star.png';
    rating.appendChild(star);
  }
  parent.appendChild(rating);

}

/**
 * I will add an h3 element along with the review title
 * @param {HTMLElement} parent
 * @param {string} title
 */
function addTitle(parent, title) {
  //don't name your variable title because that's the param name
  const titleElement = document.createElement('h3');
  titleElement.innerText = title;
  parent.appendChild(titleElement);
}

/**
 * I will add the product review
 * @param {HTMLElement} parent
 * @param {string} review
 */
function addReview(parent, review) {
  const reviewElement = document.createElement('p');
  reviewElement.innerText = review;
  parent.appendChild(reviewElement);
}

// set the product reviews page title
setPageTitle();
// set the product reviews page description
setPageDescription();
// display all of the product reviews on our page
displayReviews();
