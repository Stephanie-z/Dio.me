const increment_button = document.querySelector("#add");
const decrement_button = document.querySelector("#sub");
var currentNumberWrapper = document.getElementById("currentNumber");
var currentNumber = 0;

increment_button.addEventListener('click', () => {
    if(currentNumber < 10){
        currentNumber = currentNumber + 1;
        currentNumberWrapper.innerHTML = currentNumber;
    }
})

decrement_button.addEventListener('click', () => {
    if(currentNumber > -10){
        currentNumber = currentNumber - 1;
        currentNumberWrapper.innerHTML = currentNumber;
    }
})

/*
var currentNumberWrapper = document.getElementById("currentNumber");
var currentNumber = 0;

function increment(){
    currentNumber = currentNumber + 1;
    currentNumberWrapper.innerHTML = currentNumber;
}

function decrement(){
    currentNumber = currentNumber - 1;
    currentNumberWrapper.innerHTML = currentNumber;
   
}
*/