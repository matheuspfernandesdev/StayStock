
function urlRelativa(urlController) {

    //var protocolo = "@Request.Url.Scheme://"; var porta = "@Request.Url.Port";
    //if (porta) porta = ":" + porta;
    //var raiz = protocolo + "@Request.Url.Host" + porta + "@Request.ApplicationPath";
    //return raiz + url;

    var url = window.location.href;
    var arr = url.split("/");
    var result = arr[0] + "//" + arr[2];

    return result + urlController;
}


//Exemplo ajax
function Salvar() {

    var enderecoViewModel =
    {
        Identificador: 0,
        Bairro: $('#Bairro').val(),
        Rua: $('#Rua').val(),
        Numero: $('#Numero').val(),
        CEP: $('#Cep').val(),
        Municipio: $('#Municipio').val(),
        Telefone: $('#Telefone').val()
    };

    var model =
    {
        Identificador: 0,
        Nome: $('#Nome').val(),
        CNPJ: $('#Cnpj').val(),
        Email: $("#Email").val(),
        Descricao: $("#Descricao").val(),
        EnderecoViewModel: enderecoViewModel
    };

    $.post(urlRelativa("/Fabrica/CreatePost"), { model: model }).done(function () {
        alert("Fabrica salva com sucesso!");
    }).fail(function (result) {
        alert("Erro não previsto.");
    });
}


function startAutoValidator() {

    // initialize a validator instance from the "FormValidator" constructor.
    // A "<form>" element is optionally passed as an argument, but is not a must
    var validator = new FormValidator({
        "events": ['blur', 'input', 'change']
    }, document.forms[0]);
    // on form "submit" event
    document.forms[0].onsubmit = function (e) {
        var submit = true,
            validatorResult = validator.checkAll(this);
        console.log(validatorResult);
        return !!validatorResult.valid;
    };
    // on form "reset" event
    document.forms[0].onreset = function (e) {
        validator.reset();
    };
    // stuff related ONLY for this demo page:
    $('.toggleValidationTooltips').change(function () {
        validator.settings.alerts = !this.checked;
        if (this.checked)
            $('form .alert').remove();
    }).prop('checked', false);
}

$(document).ready(function () {

    //startAutoValidator();

});	


