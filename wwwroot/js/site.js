// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function masInformacion(id)
{
    $.Ajax({
        url: '/Home/Index',
        type : 'GET',
        dataType: 'json',

        success : function(Serie){
            $("#nombreS").html(Serie.nombre)
        }
    });
}

function Actores(id)
{
    $.Ajax({
        url: '/Home/Index',
        type : 'GET',
        dataType: 'json',

        success : function(Serie){
            $("#nombreS").html(Serie.nombre)
        }
    });
}

function Temporadas(id)
{
    $.Ajax({
        url: '/Home/Index',
        type : 'GET',
        dataType: 'json',

        success : function(Serie){
            $("#nombreS").html(Serie.nombre)
        }
    });
}

