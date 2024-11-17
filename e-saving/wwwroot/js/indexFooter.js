const currentUrl = window.location.pathname;
console.log(currentUrl)
const footerContainer = document.getElementById('footer-add');

if (currentUrl == "/") {
    footerContainer.innerHTML = "<h3>Comece agora!</h3><div><a href='/Home/SejaParceiro' id='seja-parceiro-button'> Torne-se parceiro </a><a href='/Home/SejaComprador' id='seja-comprador-button'> Torne-se comprador </a></div>";
}