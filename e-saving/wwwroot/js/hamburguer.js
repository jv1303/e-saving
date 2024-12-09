const menuToggle = document.getElementById('menu-toggle');
const menu = document.getElementById('menu');

menuToggle.addEventListener('click', () => {
    menu.classList.toggle('active');
});

document.addEventListener("DOMContentLoaded", () => {
    const menuToggle = document.getElementById("menu-toggle"); // Botão hambúrguer
    const menu = document.getElementById("menu"); // Menu principal
    const navList = document.getElementById("nav-list"); // Lista do menu

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
