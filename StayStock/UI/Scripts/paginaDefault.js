
$(".botaoProcessar").on("click", function () {
    var compactMenu = $(this).parent();
    bloqueiaDuranteRequisicaoAjax();
});

function bloqueiaDuranteRequisicaoAjax() {

    $(document).ajaxStart($.blockUI({
        baseZ: 9000,
        message: '<h1>Processando...<h1>',
        css: {
            baseZ: 9000,
            border: 'none',
            padding: '15px',
            backgroundColor: '#000',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            opacity: .5,
            color: '#fff'
        },
        overlayCSS: {
            backgroundColor: '#000',
            opacity: 0.6,
            cursor: 'wait'
        }
    })).ajaxStop($.unblockUI);
} //Função processando
