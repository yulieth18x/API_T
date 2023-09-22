document.addEventListener("DOMContentLoaded", function() {
    // Obtén una referencia a los elementos del formulario de búsqueda
    const idInput = document.getElementById("IDpro");
    const buscarButton = document.getElementById("buscarButton");
    const resultContainer = document.getElementById("resultContainer");

    // Obtén una referencia a los elementos del formulario de actualización
    const nombreInput = document.getElementById("nombre");
    const descripcionInput = document.getElementById("descripcion");
    const precioInput = document.getElementById("precio");
    const actualizarButton = document.getElementById("actualizarButton");

    // Función para buscar un producto por ID
    buscarButton.addEventListener("click", function() {
        // Obtén el valor del ID ingresado por el usuario
        const id = idInput.value;

        // URL de la API para obtener un registro por su ID
        const apiUrl = `https://localhost:44371/api/productos/${id}`;

        // Realiza una solicitud GET a la API
        fetch(apiUrl)
            .then(response => {
                if (response.ok) {
                    return response.json(); // Parsea la respuesta JSON si la solicitud fue exitosa
                } else {
                    throw new Error("Error al buscar el registro por ID");
                }
            })
            .then(data => {
                // Muestra los datos en el contenedor de resultados
                resultContainer.innerHTML = JSON.stringify(data, null, 2);

                // Llena los campos de actualización con los datos obtenidos
                nombreInput.value = data.Nombre;
                descripcionInput.value = data.Descripcion;
                precioInput.value = data.Precio;
            })
            .catch(error => {
                console.error(error);
                resultContainer.innerHTML = "Error al buscar el registro por ID";
            });
    });

   // Función para actualizar un producto
   document.getElementById("actualizarButton").addEventListener("click", function() {
    // Obtener los valores de los campos del formulario
    var IDpro = document.getElementById("actualizarID").value;
    var Nombre = document.getElementById("nombre").value;
    var Descripcion = document.getElementById("descripcion").value;
    var Precio = document.getElementById("precio").value;

    // Crear un objeto de datos JSON que deseas enviar
    var data = {
        IDpro: IDpro,
        Nombre: Nombre,
        Descripcion: Descripcion,
        Precio: Precio
    };

    // Realizar la solicitud PUT utilizando la API fetch
    fetch("https://localhost:44371/api/productos/" + IDpro, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json" // Establecer el encabezado para JSON
        },
        body: JSON.stringify(data) // Convertir el objeto de datos en una cadena JSON
    })
    .then(function(response) {
        if (response.ok) {
            return response.json(); // Parsear la respuesta JSON
        } else {
            throw new Error("Error en la solicitud PUT");
        }
    })
    .then(function(responseData) {
        // Manejar la respuesta de la API aquí
        console.log(responseData);
    })
    .catch(function(error) {
        // Manejar errores aquí
        console.error(error);
    });
});
}); 

  
  
  