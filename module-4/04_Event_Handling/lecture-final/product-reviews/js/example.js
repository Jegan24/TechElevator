
// Get the DOM elements you want to handle events for
let button = document.getElementById('save_button');

// Write a function that will handle the event
function saveForm(event) {
    event.preventDefault();

    ///...
}

// Add the function to the DOM element by adding is as a listener
button.addEventListener('click', saveForm); // No parentheses on the function name!





function test()
{

    let array=[1,4,66,86,345];
    let doubleArray = array.map( (element) => element * 2); //anonymous
    let otherDoubleArray = array.map(doubleIt); //named

}

function doubleIt(x){
    return x*2;
}