let groceries = [];
let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const anchor = document.getElementsByClassName("loadingButton")[0];
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
    li.id = "groceryItem" + item.name;

    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    if (item.completed) {
      li.classList.add("completed");
      checkCircle.classList.add("completed");
    }
    li.appendChild(checkCircle);

    ul.appendChild(li);
  });
}

function attachEvents() {
  let listItems = document.querySelectorAll("li");
  document.getElementById("toggleAll").addEventListener("click", function () { toggleAll(); })
  listItems.forEach(item => {

    item.addEventListener("click", function () { setCompleted(item) });
    item.addEventListener("dblclick", function () { setIncomplete(item) });
  })
}

function setCompleted(elem) {
  let id = getGroceryItemId(elem);
  if (!elem.classList.contains("completed")) {
    elem.classList.add("completed");
    elem.firstElementChild.classList.add("completed");
    if (id != null) {
      groceries.find(item => item.name == id).completed = true;

      updateGroceries();
    }

  }
}

function getGroceryItemId(elem) {
  let id = null;
  if (elem.id != null) {
    if (elem.id.includes("groceryItem")) {
      id = elem.id.replace("groceryItem", "");
    }
  }

  return id;
}

function setIncomplete(elem) {
  let id = getGroceryItemId(elem);
  if (elem.classList.contains("completed")) {
    elem.classList.remove("completed");
    elem.firstElementChild.classList.remove("completed");
    if (id != null) {
      groceries.find(item => item.name == id).completed = false;
      updateGroceries();
    }
  }
}


function toggleElement(elem) {
  if (elem.classList.contains("completed")) {
    elem.classList.remove("completed");
    elem.firstElementChild.classList.remove("completed");
  }
  else {
    elem.classList.add("completed");
    elem.firstElementChild.classList.add("completed")
  }
}

function toggleAll() {
  let listItems = document.querySelectorAll("li");
  let button = document.getElementById("toggleAll");


  if (button.innerText.toLowerCase().includes("incomplete")) {
    button.innerText = 'Mark All Complete';
    listItems.forEach(item => {
      setIncomplete(item);
    })
  }
  else {
    button.innerText = 'Mark All Incomplete';
    listItems.forEach(item => {
      setCompleted(item);
    })
  }
}

//setPageTitle();
//displayGroceries();




document.addEventListener("DOMContentLoaded", () => {

  anchor.addEventListener("click", onAnchorClick)
})

function onAnchorClick(event) {
  anchor.classList.add("disabled");  
  loadGroceries();
}

function loadGroceries() {
  fetch("assets/data/shopping-list.json")
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      anchor.removeEventListener("click", onAnchorClick);
      groceries = data;
      displayGroceries();
      attachEvents();      
      document.getElementById("toggleAll").classList.remove("disabled");
    })
    .catch((err) =>{
      anchor.classList.remove("disabled");
      console.error(err);
    })
}


function updateGroceries() {
  fetch("assets/data/shopping-list.json", {
    method: 'PUT',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(groceries)
  })
    .then((response) => {
      console.log('Success', groceries);
    })
    .catch((err) =>{
      console.error(err);
    })
}