// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.

function masInformacion(id)
{
    $.ajax({
        url: '/Home/traerInfo',
        type : 'GET',
        data: {id},
        dataType: 'json',

        success : function(Serie){
            let inf;
            $("#texto_informacion").html(act);        }
    });
}

function Actores(id)
{
    $.ajax({
        url: '/Home/traerActores',
        type : 'GET',
        data: {id},
        dataType: 'json',

        success: function(Actores) {
            let act = "";
            Actores.forEach(a => {
                
                act += "<b>" + a.nombre + "</b>";
                
            });
            console.log(act);
            $("#texto_informacion").html(act);
        }
    });
}

function Temporadas(id)
{
    $.ajax({
        url: '/Home/traerTemporadas',
        type : 'GET',
        data: {id},
        dataType: 'json',

        success : function(Temporadas){
            let temp = "";
            Temporadas.forEach(t => {
                temp += "<b>" + t.nombre + "</b>";
            });
            $("#texto_informacion").html(temp);        
        }
    });
}