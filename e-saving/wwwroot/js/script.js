const menuToggle = document.getElementById('menu-toggle');
const menu = document.getElementById('menu');

menuToggle.addEventListener('click', () => {
    menu.classList.toggle('active');
});

document.addEventListener("DOMContentLoaded", () => {
    const menuToggle = document.getElementById("menu-toggle"); // Botão hambúrguer
    const menu = document.getElementById("menu"); // Menu principal
    const userDiv = document.getElementById("user-div"); // Div do usuário
    const navList = document.getElementById("nav-list"); // Lista do menu

    // Simula o estado de login do usuário
    const userLogged = false; // Altere para 'true' para simular um usuário logado
    let userName;

    if (userLogged) {
        userName = "Nome de usuário"; // Nome fictício
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

    // Alterna a classe 'active' ao clicar no botão
    menuToggle.addEventListener("click", () => {
        menu.classList.toggle("active");

        // Move o conteúdo do #user-div para dentro do menu no modo responsivo
        if (menu.classList.contains("active")) {
            if (!document.getElementById("user-menu")) {
                const userMenuItem = document.createElement("li");
                userMenuItem.id = "user-menu";
                userMenuItem.className = "nav-item";
                userMenuItem.innerHTML = userDiv.innerHTML; // Copia o conteúdo do #user-div
                navList.appendChild(userMenuItem); // Adiciona no menu
            }
        } else {
            // Remove o conteúdo do #user-div do menu quando fechado
            const userMenuItem = document.getElementById("user-menu");
            if (userMenuItem) userMenuItem.remove();
        }
    });
});
