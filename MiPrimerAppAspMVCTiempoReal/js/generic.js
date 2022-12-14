

function get(id) {
    //textbox(input type='text') combos(select)
    return document.getElementById(id).value;
}

function fetchPost(url, objeto, callback) {
    Confirmacion(undefined, function () {
        fetch(url, {
            headers: {
                "Content-Type": "application/json"
            },
            method: "POST",
            body: JSON.stringify(objeto)
        }).then(res => res.text())
            .then(res => {
                //1(OK)
                if (res == 1) {
                    Exito();
                    callback()
                } else {
                    Error();
                }
            })
    });

   
}

function Error(titulo="Error",texto="Ocurrio un error") {
    Swal.fire({
        icon: 'error',
        title: titulo,
        text: texto,
        /*footer: '<a href="">Why do I have this issue?</a>'*/
    })
}

function Exito(titulo="Se guardo correctamente") {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: titulo,
        showConfirmButton: false,
        timer: 1500
    })
}

function Confirmacion(texto="Los cambios tu deseas guardarlos en tu BD", callback) {
    Swal.fire({
        title: 'Desea guardar los cambios?',
        text: texto,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes'
    }).then((result) => {
        if (result.isConfirmed) {
            Swal.fire(
                //'Deleted!',
                //'Your file has been deleted.',
                //'success'
                callback()
            )
        }
    })
}

//image (img)
function getS(id) {
    return document.getElementById(id).src;
}

function set(id, valor) {
    document.getElementById(id).value = valor;
}

function setS(id, valor) {
    document.getElementById(id).src = valor;
}

function pintar(url, id ="divTabla", cabeceras, nombrePropiedades, idTabla="tabla" ) {

    fetch(url).then(res => res.json())
        .then(res => {
            //alert(res)
            //alert(JSON.stringify(res))
            var contenido = "<table id='" + idTabla+"' class='table'>";
            contenido += "<thead>";
            contenido += "<tr>";
            for (var i = 0; i < cabeceras.length; i++) {
                contenido += "<th>"
                contenido += cabeceras[i];
                contenido+="</th>"
            }


            contenido += "</tr>";
            contenido += "</thead>";
            var objetoActual;
            var nombrePropiedad;
            contenido += "<tbody>";
            for (var i = 0; i < res.length; i++) {
                objetoActual = res[i];
                contenido += "<tr>";
                for (var j = 0; j < nombrePropiedades.length; j++) {
                    nombrePropiedad = nombrePropiedades[j];
                    contenido += "<td>";
                    contenido += objetoActual[nombrePropiedad];
                    contenido += "</td>";
                }


                contenido += "</tr>";
            }
            contenido += "</tbody>";

            contenido += "</table>";

            document.getElementById(id).innerHTML = contenido;
            //Agregamos paginado
            $("#"+idTabla).DataTable()
        })

}