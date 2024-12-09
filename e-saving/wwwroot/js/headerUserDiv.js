const userDiv = document.getElementById('user-div');  // gets the inner HTML of the user div
const userBox = document.getElementById('user-box');
var boxIn = false

if (isUserLogged == true) {
    userName = "Nome de usuário";  // defines the username

    userDiv.innerHTML = "<div id=\"logged-user-click\" onmouseover=\"showBox()\" onmouseleave=\"setTimeout(hideBox, 100)\"> <h6 id=\"user-name\"> <img src=\"/images/down-arrow.png\" id=\"user-down-arrow\" alt='Seta para baixo'> </h6> <img src=\"/images/user-icon.png\" alt=\"Ícone de usuário\" class=\"header-icon\"> </div>";  // puts the down arrow and user photo into the HTML
    // the username goes into the <h6> tag

    const userNameTag = document.getElementById('user-name');  // gets the tag where the username will go into
    userNameTag.innerHTML += nomeUsuario;  // puts the username into the HTML

} else {
    userDiv.innerHTML = "<a href='/User/' id='singin-button'> Sing in </a> <a href='/User/Login' id='login-button'> Log in </a>";  // puts the sing-in and log-in buttons into the HTML
}

document.addEventListener("DOMContentLoaded", () => {
    const menuToggle = document.getElementById("menu-toggle");
    const menu = document.getElementById("menu");

    // Alterna a visibilidade do menu ao clicar no botão hambúrguer
    menuToggle.addEventListener("click", () => {
        menu.classList.toggle("active");
    });

});
function showBox() {
    userBox.classList = "mouseIn"
}

function hideBox() {
    if (boxIn == false) {
        userBox.classList = "mouseOut"
    }
}

function boolBoxIn() {
    boxIn = true
    console.log(boxIn)
}

function boolBoxOut() {
    boxIn = false
    console.log(boxIn)
}

function logOut() {
    fetch('/Home/UpdateUserLogged', {
        method: 'POST',
    })
    location.reload()
}
