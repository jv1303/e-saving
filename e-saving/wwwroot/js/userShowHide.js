const nav = document.getElementById("nav-list")

console.log("deu")

if (isPartner == "true") {
    nav.innerHTML += "<li class=\"nav-item\"><a href=\"/Home/AreaParceiro\">Área do usuário</a></li>"
} else if (restricao == "parceiro") {
    const main = document.getElementById("main")
    main.innerHTML = "<div class=\"grid\"><section class=\"content-section\"><h2 class=\"section-subtitle-bold\">Você não possui acesso a essa página!</h2><p class=\"section-paragraph\">Para conseguir acesso a esta página, faça login na sua conta.</p><p class=\"section-paragraph\">Caso não possua uma conta, você pode facilmente realizar o cadastro como usuário, parceiro ou comprador.</p></section><br><br><br><br><section style=\"display: flex; justify-content: space-around;\"><div class=\"generic-button\"><a href='/User/'> Cadastrar-se </a></div><div class=\"generic-button\"><a href='/User/Login'> Entrar </a></div></section></div>"
}

if (isClient == "true") {
    nav.innerHTML += "<li class=\"nav-item\"><a href=\"/Home/AreaUsuario\">Área do usuário</a></li>"
} else if (restricao == "usuario") {
    const main = document.getElementById("main")
    main.innerHTML = "<div class=\"grid\"><section class=\"content-section\"><h2 class=\"section-subtitle-bold\">Você não possui acesso a essa página!</h2><p class=\"section-paragraph\">Para conseguir acesso a esta página, faça login na sua conta.</p><p class=\"section-paragraph\">Caso não possua uma conta, você pode facilmente realizar o cadastro como usuário, parceiro ou comprador.</p></section><br><br><br><br><section style=\"display: flex; justify-content: space-around;\"><div class=\"generic-button\"><a href='/User/'> Cadastrar-se </a></div><div class=\"generic-button\"><a href='/User/Login'> Entrar </a></div></section></div>"
}

if (isBuyer == "true") {
    nav.innerHTML += "<li class=\"nav-item\"><a href=\"/Home/AreaComprador\">Área do comprador</a></li>"
} else if (restricao == "comprador") {
    const main = document.getElementById("main")
    main.innerHTML = "<div class=\"grid\"><section class=\"content-section\"><h2 class=\"section-subtitle-bold\">Você não possui acesso a essa página!</h2><p class=\"section-paragraph\">Para conseguir acesso a esta página, faça login na sua conta.</p><p class=\"section-paragraph\">Caso não possua uma conta, você pode facilmente realizar o cadastro como usuário, parceiro ou comprador.</p></section><br><br><br><br><section style=\"display: flex; justify-content: space-around;\"><div class=\"generic-button\"><a href='/User/'> Cadastrar-se </a></div><div class=\"generic-button\"><a href='/User/Login'> Entrar </a></div></section></div>"
}