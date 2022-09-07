

function get(id) {
    //textbox(input type='text') combos(select)
    return document.getElementById(id).value;
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

function pintar(url, id ) {

    fetch(url).then(res => res.json())
        .then(res => {
            alert(res)
            alert(JSON.stringify(res))
        })

}