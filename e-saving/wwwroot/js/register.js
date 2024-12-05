var inputCount;
const inputDiv = document.getElementsByClassName("user-input");
const submit = document.getElementById("submit-button");

function next() {
    if (inputCount == 0) {
        submit.type = "submit"
    } else {
        if (inputDiv[0].classList.includes("display-" + inputCount) == true) {
            console.log("deu")
        }
    }
}

console.log(inputDiv)