function buscarEndereco() {
    const cep = document.getElementById('cep').value.replace(/\D/g, ''); // Remove caracteres não numéricos
    const logradouroInput = document.getElementById('logradouro');
    const cidadeInput = document.getElementById('cidade');
    const estadoInput = document.getElementById('estado');

    if (cep.length === 8) {
        // Faz a requisição para a API ViaCEP
        fetch(`https://viacep.com.br/ws/${cep}/json/`)
            .then(response => response.json())
            .then(data => {
                if (data.erro) {
                    alert('CEP não encontrado!');
                } 
                else {
                    // Preenche os campos com os dados recebidos
                    logradouroInput.value = data.logradouro;
                    cidadeInput.value = data.localidade;
                    estadoInput.value = data.uf;
                    // Torna os campos visíveis
                    document.querySelectorAll('.display-2').forEach(el => el.classList.remove('hidden'));
                }
            })
            .catch(error => {
                alert('Erro ao buscar o CEP!');
                console.error(error);
            });
    } 
    else {
        alert('CEP inválido!');
    }
}