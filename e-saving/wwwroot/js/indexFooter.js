const currentUrl = window.location.pathname;
console.log(currentUrl)
const footerContainer = document.getElementById('footer-add');

if (currentUrl == "/") {
    footerContainer.innerHTML = "";
}