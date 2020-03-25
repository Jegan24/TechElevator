
let reviews=[];

function loadReviews(){
  console.log("Load reviews...");
console.error("Oh no!")
  //do the fetch
  fetch('data.json')
  .then( (response) => {
    return response.json();
  })
  .then( (data) => {
    reviews = data;
    displayReviews();
  })
  .catch( (err)=> {console.error(err)});
  console.log("finished loading reviews");
}

document.addEventListener('DOMContentLoaded', ()=>{
  //add the event listener for our button
  const button = document.querySelector('.btn');
  button.addEventListener('click', (event) => {
    loadReviews();
    button.disabled = true;
    LoadImage();
  });
  LoadImage();

})

/**
 * This function when invoked will look at an array of reviews
 * and add it to the page by cloning the #review-template
 */
function displayReviews() {
    console.log("Display Reviews...");
  
    // first check to make sure the browser supports content templates
    if('content' in document.createElement('template')) {
      // query the document for .reviews and assign it to a variable called container
      const container = document.querySelector(".reviews");
      // loop over the reviews array
      reviews.forEach((review) => {
        // get the template; find all the elements and add the data from our review to each element
        const tmpl = document.getElementById('review-template').content.cloneNode(true);
        SetImageToCatPic( tmpl.querySelector('img'));
        //this doesn't work because we aren't waiting on load image to finish
       // tmpl.querySelector('img').setAttribute("src",LoadImage());
        tmpl.querySelector('.username').innerText = review.username;
        tmpl.querySelector('h2').innerText = review.title;
        tmpl.querySelector('.published-date').innerText = review.publishedOn;
        tmpl.querySelector('.user-review').innerText = review.review;
        container.appendChild(tmpl);
      });
    } else {
      console.error('Your browser does not support templates');
    }
}

function SetImageToCatPic(element){
  fetch('https://api.thecatapi.com/v1/images/search?category_ids=15')
  .then( (response) => {
    return response.json();
  })
  .then ( (data)=>{
    element.src = data[0].url;
  })
  .catch((err)=> console.error(err));
}

function LoadImage(){
  let imageUrl;
  console.log("lets get a cat image");
  fetch('https://api.thecatapi.com/v1/images/search?category_ids=15')
  .then( (response) => {
    return response.json();
  })
  .then ( (data)=>{
    imageUrl = data[0].url;
    SetCatPicUrl(imageUrl);
  })
  return imageUrl;
}

function SetCatPicUrl(url){
  //grab the image element
  const imgElement = document.getElementById('cat-pic'); 
  //set the src to url
  imgElement.src = url;
}
//Let's have some fun and instead of using fetch to call a json file, let's use a real API
// https://api.thecatapi.com/v1/images/search?category_ids=15
