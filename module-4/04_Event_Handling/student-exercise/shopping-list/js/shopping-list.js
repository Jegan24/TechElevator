let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

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
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

function attachEvents(){
  let listItems = document.querySelectorAll("li");
  document.getElementById("toggleAll").addEventListener("click", function(){toggleAll();})
  listItems.forEach(item =>{
    
    item.addEventListener("click", function() {setCompleted(item)});
    item.addEventListener("dblclick", function() {setIncomplete(item)});
  })
}

function setCompleted(elem){
  if(!elem.classList.contains("completed")){
      elem.classList.add("completed");
      elem.firstElementChild.classList.add("completed")
  }
}

function setIncomplete(elem){
  if(elem.classList.contains("completed")){
      elem.classList.remove("completed");
      elem.firstElementChild.classList.remove("completed");
  }
}

function toggleElement(elem){
  if(elem.classList.contains("completed")){
    elem.classList.remove("completed");
    elem.firstElementChild.classList.remove("completed");
  }
  else{
    elem.classList.add("completed");
    elem.firstElementChild.classList.add("completed")
  }
}

function toggleAll(){
  let listItems = document.querySelectorAll("li");
  let button = document.getElementById("toggleAll");
  

  if(button.innerText.toLowerCase().includes("incomplete")){
    button.innerText = 'Mark All Complete';
    listItems.forEach(item =>{
      setIncomplete(item);
    })
  }
  else{
    button.innerText = 'Mark All Incomplete';
    listItems.forEach(item =>{
      setCompleted(item);
    })
  }
}

setPageTitle();
displayGroceries();

attachEvents();

