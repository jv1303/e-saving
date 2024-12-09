// Função para formatar o CPF

function formatarCPF(input) {
    let value = input.value.replace(/\D/g, ''); // Remove todos os caracteres não numéricos
    if (value.length <= 11) {
        value = value.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, '$1.$2.$3-$4');
    }
    input.value = value;
}
