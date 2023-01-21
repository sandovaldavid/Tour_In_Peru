const imagen = document.querySelector("#buscarImg");
const imagenMostrar = document.querySelector("#imagenMostrar");
/*
let img_subida;
const CLOUDINARY_URL = ``;
const CLOUDINARY_UPLOAD_PRESET = `tjr0ocvn`;
imagen.addEventListener("change", (event) => {
    img_subida = event.target.files[0];
    console.log(img_subida);
    subirImagen();
});

const subirImagen = () => {
    try {
        return fetch(CLOUDINARY_API).then((respuesta) => {
            respuesta;
        });
    } catch (error) {
        console.log(error);
    }
    
};
*/
const btn_agregarProducto = document.querySelector("[data-agregarProducto]");
btn_agregarProducto.addEventListener("click", (event) => {
    event.preventDefault();
    const nombreProducto = document.querySelector("#NombreProducto").value;
    const precioProducto = document.querySelector("#precioProducto").value;
    const descripcion = document.querySelector("#descripcion").value;

    const producto = ``;
    //estos datos de de esta pagina, tengo que enviarlas a la pagina de mostrar producto
});

