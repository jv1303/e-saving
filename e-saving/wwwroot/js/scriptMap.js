// Criar o mapa centrado em São Paulo
var map = L.map('map').setView([-23.5505, -46.6333], 12); // Coordenadas para São Paulo

// Adicionar camada de mapa (usando OpenStreetMap)
L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
}).addTo(map);

// Adicionar marcadores de ecopontos (Exemplo)
var ecopontos = [
    {
        name: "Ecoponto 1",
        lat: -23.5635,
        lon: -46.6545
    },
    {
        name: "Ecoponto 2",
        lat: -23.5580,
        lon: -46.6340
    },
    {
        name: "Ecoponto 3",
        lat: -23.5600,
        lon: -46.6200
    }
    // Adicione outros ecopontos aqui
];

// Loop para adicionar os marcadores no mapa
ecopontos.forEach(function(ecoponto) {
    L.marker([ecoponto.lat, ecoponto.lon])
        .addTo(map)
        .bindPopup("<b>" + ecoponto.name + "</b>");
});
