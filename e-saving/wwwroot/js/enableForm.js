const inputs = document.getElementsByClassName("form-input");

function editToggle() {
    if (inputs[0].disabled) {
        for (var i = inputs.length - 1; i >= 0; i--) { // Fix the range
            inputs[i].disabled = false; // Enable the inputs
        }
    } else {
        for (var i = inputs.length - 1; i >= 0; i--) { // Fix the range
            inputs[i].disabled = true; // Disable the inputs
        }
    }
}