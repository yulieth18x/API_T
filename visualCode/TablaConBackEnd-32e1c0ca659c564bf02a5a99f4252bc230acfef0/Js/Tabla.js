

const tableContainer = document.getElementById("table-container");

// Crea la tabla y su encabezado
const table = document.createElement("table");
const thead = document.createElement("thead");
const headerRow = document.createElement("tr");
const headers = ["IDpro","Nombre", "Descripción", "Precio"]; // Encabezados de la tabla

// Agrega los encabezados a la fila de encabezado
headers.forEach(headerText => {
  const header = document.createElement("th");
  header.textContent = headerText;
  headerRow.appendChild(header);
});

// Agrega la fila de encabezado al encabezado de la tabla
thead.appendChild(headerRow);
table.appendChild(thead);

// Agrega el cuerpo de la tabla
const tbody = document.createElement("tbody");
table.appendChild(tbody);

// URL de la API de productos
const apiURL = "https://localhost:44371/api/productos"; // Reemplaza esto con la URL real de tu API de productos

// Realiza la solicitud a la API
fetch('https://localhost:44371/api/productos')
  .then(response => response.json())
  .then(data => {
    // Itera a través de los datos de la API y agrega filas a la tabla
    data.forEach(producto => {
      // Crea una nueva fila <tr>
      const fila = document.createElement("tr");
    
      // Agrega una celda para el ID (IDpro)
      const celdaID = document.createElement("td");
      celdaID.textContent = producto.IDpro; // Asegúrate de que la propiedad sea la correcta
      fila.appendChild(celdaID);
    
      const celdaNombre = document.createElement("td");
      celdaNombre.textContent = producto.Nombre;
      fila.appendChild(celdaNombre);
    
      const celdaDescripcion = document.createElement("td");
      celdaDescripcion.textContent = producto.Descripcion;
      fila.appendChild(celdaDescripcion);
    
      const celdaPrecio = document.createElement("td");
      celdaPrecio.textContent = producto.Precio;
      fila.appendChild(celdaPrecio);
    
      // Agrega la fila al cuerpo de la tabla
      tbody.appendChild(fila);
    });
  })
  .catch(error => {
    console.error("Hubo un error al obtener los datos de la API:", error);
  });

// Agrega la tabla al contenedor en el HTML
tableContainer.appendChild(table);

