
document.addEventListener('DOMContentLoaded',() => {
    const button = document.getElementById('btnSave');
    button.addEventListener('click',addReview);

    const title = document.getElementById('title');
    const reviewer = document.getElementById('reviewer');
    const rating = document.getElementById('rating');
    const review = document.getElementById('review');

    const titleResult = document.querySelector('.titleResult');
    const reviewerResult = document.querySelector('.reviewerResult');
    const ratingResult = document.querySelector('.ratingResult');
    const reviewResult = document.querySelector('.reviewResult');

    title.addEventListener('keyup',(event)=>{
        titleResult.innerText = event.target.value;
    });
    reviewer.addEventListener('keyup',(event)=>{
        reviewerResult.innerText = event.target.value;
    });
    rating.addEventListener('change',(event)=>{
        ratingResult.innerText = event.target.value;
    });
    review.addEventListener('keyup',(event)=>{
        reviewResult.innerText = event.target.value;
    });

});

function addReview(event) {
    event.preventDefault();

    const title = document.getElementById('title');
    const reviewer = document.getElementById('reviewer');
    const rating = document.getElementById('rating');
    const review = document.getElementById('review');

    const titleResult = document.querySelector('.titleResult');
    const reviewerResult = document.querySelector('.reviewerResult');
    const ratingResult = document.querySelector('.ratingResult');
    const reviewResult = document.querySelector('.reviewResult');

    titleResult.innerText = title.value;
    reviewerResult.innerText = reviewer.value;
    ratingResult.innerText = rating.value;
    reviewResult.innerText = review.value;
}