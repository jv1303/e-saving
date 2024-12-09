// Função para formatar o CNPJ

function formatarCNPJ(input) {
    let value = input.value.replace(/\D/g, ''); // Remove todos os caracteres não numéricos
    if (value.length <= 14) {
        // Formata o CNPJ no formato xx.xxx.xxx/xxxx-xx
        value = value.replace(/(\d{2})(\d{3})(\d{3})(\d{4})(\d{2})/, '$1.$2.$3/$4-$5');
    }
    input.value = value;
}
