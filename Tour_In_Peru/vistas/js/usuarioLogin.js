
const btn_login = document.querySelector("[data-login]");
const email = document.querySelector("#login__email").value;
const password = document.querySelector("#login__clave").value;

const usuario = {
    email: "david@alura.com",
    password: "12345",
};

function login() {
    if (email == "david@alura.com" && password == "12345") {
        alert("Bienbenido");
    } else {
        alert("pass incorrecta")
    }
}


btn_login.addEventListener("onclick", (event) => {
    login();
});