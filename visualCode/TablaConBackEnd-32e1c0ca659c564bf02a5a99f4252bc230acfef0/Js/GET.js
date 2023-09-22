document.addEventListener("DOMContentLoaded", function() {
    // Obtén una referencia al elemento de entrada del ID
    const idInput = document.getElementById("IDpro");
    
    // Obtén una referencia al elemento donde mostrarás los datos
    const resultContainer = document.getElementById("resultContainer");
    
    // Agrega un evento al botón para buscar un registro por ID
    const searchButton = document.getElementById("searchButton");
    searchButton.addEventListener("click", function() {
      // Obtén el valor del ID ingresado por el usuario
      const id = idInput.value;
      
      // URL de la API para obtener un registro por su ID
      const apiUrl = `https://localhost:44371/api/productos/${id}`; // Usar comillas invertidas
    
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
        })
        .catch(error => {
          console.error(error);
          resultContainer.innerHTML = "Error al buscar el registro por ID";
        });
    });
  });
  