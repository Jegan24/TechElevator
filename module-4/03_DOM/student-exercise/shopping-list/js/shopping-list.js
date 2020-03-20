// add pageTitle
let pageTitle = "My Shopping List";
// add groceries
let groceries = ['Toilet Paper 2 Pack', 'Toilet Paper 4 Pack', 'Toilet Paper 8 Pack', 'Toilet Paper 16 Pack', 'Toilet Paper 32 Pack', 'Toilet Paper 64 Pack', 'Toilet Paper 128 Pack',
'Toilet Paper 256 Pack', 'Toilet Paper 512 Pack', 'Toilet Paper 1024 Pack' ];
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  document.title = pageTitle;
  document.getElementById("title").innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  let list = document.getElementById("groceries");
  groceries.forEach(item => {
    let newItem = document.createElement("li");
    newItem.innerText = item;
    list.appendChild(newItem);
  });
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  let items = Array.prototype.slice.call(document.getElementById("groceries").children);
  items.forEach(item =>{
    item.classList.add("completed");
  })
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
