const currentUrl = window.location.pathname;
console.log(currentUrl)
const footerContainer = document.getElementById('footer-add');

if (currentUrl == "/") {
    footerContainer.innerHTML = "<h3>Comece agora!</h3><div><a href='/User/Register' id='seja-parceiro-button'> Sing in </a><a href='/User/Login' id='seja-comprador-button'> Log in </a></div>";
}