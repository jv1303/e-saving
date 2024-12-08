// it changes the inner HTML of the user div container depending if the user is logged or not

var userLogged = false;  // checks if the user is logged or not
const userDiv = document.getElementById('user-div');  // gets the inner HTML of the user div
var userName;  // gets the username

if (userLogged == true) {
    userName = "Nome de usuário";  // defines the username

    userDiv.innerHTML = "<div id=\"logged-user-click\"> <h6 id=\"user-name\"> <img src=\"/images/down-arrow.png\" id=\"user-down-arrow\" alt='Seta para baixo'> </h6> <img src=\"/images/user-icon.png\" alt=\"Ícone de usuário\" class=\"header-icon\"> </div>";  // puts the down arrow and user photo into the HTML
    // the username goes into the <h6> tag

    const userNameTag = document.getElementById('user-name');  // gets the tag where the username will go into
    userNameTag.innerHTML += userName;  // puts the username into the HTML

} else {
    userDiv.innerHTML = "<a href='/User/Register' id='singin-button'> Sing in </a> <a href='/User/Login' id='login-button'> Log in </a>";  // puts the sing-in and log-in buttons into the HTML
}

document.addEventListener("DOMContentLoaded", () => {
    const menuToggle = document.getElementById("menu-toggle");
    const menu = document.getElementById("menu");

    // Alterna a visibilidade do menu ao clicar no botão hambúrguer
    menuToggle.addEventListener("click", () => {
        menu.classList.toggle("active");
    });

    // Manipula o estado de login do usuário
    var userLogged = false; // Simula o estado de login do usuário
    const userDiv = document.getElementById('user-div');
    var userName;

    if (userLogged) {
        userName = "Nome de usuário"; // Nome fictício do usuário

        userDiv.innerHTML = `
            <div id="logged-user-click">
                <h6 id="user-name">
                    ${userName}
                    <img src="/images/down-arrow.png" id="user-down-arrow" alt="Seta para baixo">
                </h6>
                <img src="/images/user-icon.png" alt="Ícone de usuário" class="header-icon">
            </div>`;
    } else {
        userDiv.innerHTML = `
            <a href="/User/Register" id="singin-button">Sign in</a>
            <a href="/User/Login" id="login-button">Log in</a>`;
    }
});
