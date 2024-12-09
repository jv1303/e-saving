var map = L.map('map').setView([-23.5492, -46.7299], 13);

L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
}).addTo(map);

// Adicionar marcadores de ecopontos (Exemplo)
var ecopontos = [
    {
        name: "Ecoponto - Liberdade",
        lat: -23.5561,
        lon: -46.6346
    },
    {
        name: "Ecoponto - Metalúrgicos",
        lat: -23.5642,
        lon: -46.8138
    },
    {
        name: "Ecoponto - Vila dos Remédios",
        lat: -23.5138,
        lon: -46.7541
    },
    {
        name: "Ecoponto - Parque Imperial",
        lat: -23.4903,
        lon: -46.8049
    },
    {
        name: "Ecoponto - Jardim das Belezas",
        lat: -23.5257,
        lon: -46.8405
    }
];

// Loop para adicionar os marcadores no mapa
ecopontos.forEach(function(ecoponto) {
    L.marker([ecoponto.lat, ecoponto.lon])
        .addTo(map)
        .bindPopup("<b>" + ecoponto.name + "</b>");
});