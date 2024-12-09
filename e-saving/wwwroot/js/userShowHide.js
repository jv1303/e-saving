const nav = document.getElementById("nav-list")

if (isPartner) {
    nav.innerHTML += "<li class=\"nav-item\"><a asp-area=\"\" asp-controller=\"Home\" asp-action=\"AreaParceiro\">Área do parceiro</a></li>"
}