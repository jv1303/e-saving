//const inputs = document.getElementsByClassName("form-input");
//
//function editToggle() {
//    if (inputs[0].disabled) {
//        for (var i = inputs.length - 1; i >= 0; i--) { // Fix the range
//            inputs[i].disabled = false; // Enable the inputs
//        }
//    } else {
//        for (var i = inputs.length - 1; i >= 0; i--) { // Fix the range
//            inputs[i].disabled = true; // Disable the inputs
//        }
//    }
//}
const inputs = document.getElementsByClassName("form-input");
const submitButton = document.querySelector(".form-submit");

function editToggle(){
    const shouldEnable = inputs[0].disabled; //Determina o estado
    for (let i =0; i < inputs.length; i++){
        inputs[i].disabled = !shouldEnable; //Define o estado com base no primeiro input
    }
    inputs.forEach(input => {
        input.disabled = !shouldEnable;
    });
    if (submitButton) {
        submitButton.disabled = !shouldEnable; // Habilita/desabilita o botão de submissão
    }
}