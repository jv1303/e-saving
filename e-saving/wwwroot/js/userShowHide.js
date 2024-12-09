const nav = document.getElementById("nav-list")

if (isPartner) {
    nav.innerHTML += "<li class=\"nav-item\"><a href=\"/Home/AreaParceiro\">Área do parceiro</a></li>"
} else if (restricao == "parceiro") {
    const main = document.getElementById("main")
    main.innerHTML = "seu fudeu ladrao"
}

if (isClient) {
    nav.innerHTML += "<li class=\"nav-item\"><a href=\"/Home/AreaUsuario\">Área do usuário</a></li>"
} else if (restricao == "usuario") {
    const main = document.getElementById("main")
    main.innerHTML = "seu fudeu ladrao"
}

if (isBuyer) {
    nav.innerHTML += "<li class=\"nav-item\"><a href=\"/Home/AreaComprador\">Área do comprador</a></li>"
} else if (restricao == "comprador") {
    const main = document.getElementById("main")
    main.innerHTML = "seu fudeu ladrao"
}