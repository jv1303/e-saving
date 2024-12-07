var inputCount, nextCount, isRegister
const inputDiv = document.getElementsByClassName("user-input");
const submit = document.getElementById("submit-button");
const userForm = document.getElementById("user-form");
const inputElement = document.getElementsByClassName("input-element");
const emails = document.getElementsByName("email")
const passwords = document.getElementsByName("password")

function next() {
    if (isRegister) {
        if ((userForm.checkValidity() == false) || (emails[0].value != emails[1].value) || (passwords[0].value != passwords[1].value)) {
            alert("Preencha todos os campos corretamente para continuar.")
            return
        }
    }

    if (nextCount == 1) {
        submit.value = "Cadastrar-se"
    }
    if (nextCount == 0) {
        submit.type = "submit"
        switchLogged("in")
        updateUserDiv()
    } else {
        for (var i = inputCount; i > -1; i--) {
            if (inputDiv[i].classList.contains("display-" + nextCount)) {
                inputDiv[i].style.display = "flex"
                inputElement[i].required = true
            } else {
                inputDiv[i].style.display = "none"
            }
        }
    }
    nextCount -= 1
}