
function startColorPicker() {
    $('.colorHex').colorpicker();
}

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

function addItem() {

    //$.ajax({
    //    url: '@Url.Action("NovaCorQuantidade", "Estoque")'
    //}).success(function (model) {
    //    $('#tabelaProdutoQuantidade').append(model);
    //});

    $.get(urlRelativa("/Estoque/NovaCorQuantidade"), {}, function (model) {
        console.log(model);
        $('#tabelaProdutoQuantidade tbody').append(model);
    });

    //$.getJSON(urlRelativa("/Estoque/NovaCorQuantidade"), {}, function (model) {
    //    console.log(model);
    //    $('#tabelaProdutoQuantidade tbody').append(model);
    //});


    //Esse funciona, mas nao tem o begin form da partial que eu quero
    //var qtdProdutoEstoque = $('#tabelaProdutoQuantidade tr').length - 1;
    //$.get(urlRelativa("/Estoque/ObterCores"), { qtdProdutoEstoque: qtdProdutoEstoque }, function (model) {

    //    $('#tabelaProdutoQuantidade').append(
    //        '<tr>' +
    //            '<td>' + 
    //                model + 
    //            '</td> ' +
    //            '<td>' +
    //                '<div class="input-group colorHex">' +
    //                    '<input type="text" id="CodigoHex" name="CodigoHex" required="required" class="form-control" />' +
    //                    '<span class="input-group-addon"><i></i></span>' +
    //                '</div>' +
    //            '</td >' +
    //            '<td>' +
    //                '<input type="text" class="form-control quantidade" />' +
    //            '</td > ' +
    //            '<td>' +
    //                '<input type="text" class="form-control descricao" name="descricao" />' +
    //            '</td>' + 
    //            '<td class= "text-center">' +
    //                '<button type = "button" class= "btn btn-warning text-center" onclick="excluirRow(this)">' + 
    //                '<i class= "fa fa-trash" title="Excluir Produto Quantidade" ></i></button> ' +
    //            '</td >' + 
    //        '</tr >');
    //});
}


function excluirRow(row) {
    $(row).parent().parent().remove();
}

//Exemplo ajax
function Salvar() {

    var qtdProdutoEstoque = $('#tabelaProdutoQuantidade tr').length - 1;
    var i;

    //for (i = 0; i < qtdProdutoEstoque; i++) {

    //}

    var listaCorQuantidade =
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
        NomeProduto: $('#NomeProduto').val(),
        NumeroSerie: $('#NumeroSerie').val(),
        ValorVenda: $('#ValorVenda').val(),
        IdentificadorTipoProduto: $("#Fabrica").val(),
        IdentificadorFabrica: $("#TipoProduto").val(),
        ListaCorQuantidade: listaCorQuantidade
    };

    //$("#tabela").find("tbody >tr").each(function () {
    //    model.Formas.push({
    //        Quantidade: $(this).find("#quantidade").val(),
    //        IdentificadorForma: $(this).find("#dropForma").val(),
    //        Total: $(this).find("#total").text(),
    //    });
    //});

    //$.post(urlRelativa("/Orcamento/Salvar"), { model: model }).done(function () {
    //    alert("Orçamento salvo com sucesso!")
    //}).fail(function (result) {

    //    alert("Erro não previsto.");
    //});


    $.post(urlRelativa("/Estoque/Create"), { model: model }).done(function () {
        //alert("Fabrica salva com sucesso!");
    }).fail(function (result) {
        alert("Erro não previsto.");
    });
}

$(document).ready(function ($) {
    startColorPicker();
});

$(document).on('change', '.dropCores', function () {

    if ($(this).val() !== "0") {

        var id = $(this).val();
        var teste = $(this);

        $.get(urlRelativa("/Estoque/ObterCodigoCor"), { id: id }, function (model) {

            teste.closest('td').next('td').find('input').val(model);
            teste.closest('td').next('td').find('input').attr("value", model);
            teste.closest('td').next('td').find('div').find('span').find('i').attr('style', 'background-color: ' + model);

            teste.closest('td').next('td').find('input').attr("readonly", true);
            teste.closest('td').next('td').find('input').attr("disabled", true);
            teste.closest('td').next('td').find('div').find('span').css("pointer-events", "none");
            startColorPicker();
        });

    }
});

$(document).on('click', '#sendForm', function () {
    Salvar();
});

