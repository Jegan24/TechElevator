const name = 'Cigar Parties for Dummies';
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
  pageTitle.querySelector('.name').innerText = name;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  document.querySelector('.description').innerText = description;
}

/**
 * I will display all of the reviews on the page.
 * I will loop over the array of reviews and use some helper functions
 * to create the elements needed for our markup and add them to the DOM
 */
function displayReviews() {
  const main = document.getElementById('main');

  reviews.forEach( (review) => {
    const container = document.createElement('div');

    //this will replace the list of classes with 'review'
    //container.setAttribute('class','review');

    //this will add 'review' to the list of classes
    container.classList.add('review'); 

    addReviewer(container,review.reviewer);

    //add the rating
    addRating(container, review.rating);
    //add the title
    addTitle(container,review.title);
    //add the review
    addReview(container,review.review);

    main.insertAdjacentElement('beforeend',container);

  });
}

//create and call a method that uses queryseletorall to demo
function makeReviewBackgroundsPurple(){

  //this will only pickup divs with class .review
  let reviewList = document.querySelectorAll('div .review');

  //this line will pick up the h1 that says test
  //let reviewList = document.querySelectorAll(' .review');
  reviewList.forEach( (div) => 
    div.style.background='plum');

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
 * I will add the rating div along with a star image for the number of ratings 1-5
 * @param {HTMLElement} parent
 * @param {Number} numberOfStars
 */
function addRating(parent, numberOfStars) {
  const ratingDiv = document.createElement("div");
  ratingDiv.setAttribute("class", "rating");
  for(let i = 0; i < numberOfStars; i++){
    const image = document.createElement("img");
    image.setAttribute("src", "img/star.png");
    image.setAttribute("class", "ratingStar");
    ratingDiv.appendChild(image);
    }
    parent.appendChild(ratingDiv);
}

/**
 * I will add an h3 element along with the review title
 * @param {HTMLElement} parent
 * @param {string} title
 */          
function addTitle(parent, title) {
   const titleElement = document.createElement('h3');
   titleElement.innerText = title;
   parent.appendChild(titleElement);//how do i give back control?I cant unmute when typing on katies screen

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



// A $( document ).ready() block.
$( document ).ready(function() {
  attachEvents();
});

function attachEvents(){
  let stars = getSelectStarElements();
  let ratingDiv = document.getElementById("ratingPicker");
  ratingDiv.addEventListener("mouseleave", function(){hideStars()});
  stars.forEach(star =>{
    let starRating = star.id.substring(0,1);
    star.addEventListener("click", function(){ starClick(starRating)});
    star.addEventListener("mouseenter", function(){showStars(starRating)});    
  })
}

function starClick(starRating){
  document.getElementById("selectedRating").value = starRating * 1;
  showStars(starRating);
}

function showStars(starRating){
  let stars = getSelectStarElements();
  for(let i = 1; i <= 5; i++ ){
    let star = document.getElementById(i + "star");
    if(i <= starRating){
      star.classList.remove("starInvisible");
      star.classList.add("starVisible");
    }
    else{
      star.classList.remove("starVisible");
      star.classList.add("starInvisible");
    }
  }
}

function hideStars(){
  showStars(document.getElementById("selectedRating").value);
}

function getSelectStarElements(){
  return Array.prototype.slice.call(document.getElementsByClassName("selectStar"));
}