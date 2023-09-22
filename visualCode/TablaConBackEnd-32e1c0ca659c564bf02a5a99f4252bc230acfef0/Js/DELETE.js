document.addEventListener("DOMContentLoaded", function() {
  // Obtén una referencia al elemento de entrada del ID
  const idInput = document.getElementById("IDpro");

  // Agrega un evento al botón para eliminar un registro por ID
  const eliminarButton = document.getElementById("eliminarButton");
  eliminarButton.addEventListener("click", function() {
    // Obtén el valor del ID ingresado por el usuario
    const id = idInput.value;

    // URL de la API para eliminar un registro por su ID
    const apiUrl = `https://localhost:44371/api/productos/${id}`;

    // Realiza una solicitud DELETE a la API
    fetch(apiUrl, {
      method: "DELETE",
      headers: {
        "Content-Type": "application/json" // Establecer el encabezado para JSON
      }
    })
    .then(response => {
      if (response.ok) {
        // La solicitud se realizó con éxito
        console.log('Producto eliminado con éxito.');
      } else {
        // Se produjo un error en la solicitud
        console.error('Error al eliminar el Producto.');
      }
    })
    .catch(error => {
      console.error('Error en la solicitud: ', error);
    });
  });
});
  