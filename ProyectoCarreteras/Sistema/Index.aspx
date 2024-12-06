<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProyectoCarreteras.Sistema.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formulario con Tabs</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <style>
        body, html {
            height: 100%;
            margin: 0;
            background-color: #add8e6; /* Celeste */
            display: flex;
            justify-content: center;
            align-items: start;
            padding-top: 0px;
        }

        .container {
            max-width: 1200px;
            padding-top: 20px;
        }

        .table-container {
            background-color: rgba(255, 255, 255, 0.9);
            border-radius: 10px;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.2);
            padding: 30px;
            margin-top: 20px;
            margin-bottom: 20px;
        }

        .table-responsive-container {
            overflow-y: auto;
            max-height: 400px;
            border: 1px solid #ddd;
        }

        .table td {
            overflow: auto;
            white-space: normal;
        }
    </style>
</head>
<body>
    <div class="table-container">
        <h2 style="text-align: center;" class="mb-4">Registros Agregados</h2>
        <div class="table-responsive-container">
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th>Id_Tipo_Adquisicion</th>
                        <th>Descripcion</th>
                        <th>Estado</th>
                        <th>Fecha_Registro</th>
                        <th>Usuario</th>
                    </tr>
                </thead>
                <tbody id="registroDatos">
                </tbody>
            </table>
        </div>
        <div class="pagination">
            <button id="prevPage" onclick="prevPage()">Anterior</button>
            <span id="pageInfo"></span>
            <button id="nextPage" onclick="nextPage()">Siguiente</button>
        </div>
    </div>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
    <script>

        $(document).ready(function () {
            obtenerRegistros(); // Llama a la función para obtener y mostrar los registros al cargar la página
        });

        // Función para obtener los registros de la base de datos y mostrarlos directamente
        function obtenerRegistros() {
            $.ajax({
                type: "POST",
                url: "Prueba2.aspx/ObtenerTiposAdquisicion", // Aquí se hace la llamada a un WebMethod
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    // Suponemos que response.d ya contiene el arreglo de registros
                    const registros = response.d;

                    // Llama a la función para mostrar los datos en la tabla
                    mostrarRegistros(registros);
                },
                error: function (error) {
                    console.error("Error al obtener los registros:", error);
                }
            });
        }

        // Función para dar formato a una fecha ASP.NET
        function formatearFecha(fechaASP) {
            // Extraer los milisegundos del formato /Date(1707769813263)/
            const milisegundos = parseInt(fechaASP.match(/\d+/)[0], 10);
            const fecha = new Date(milisegundos);

            // Formatear la fecha
            const dia = String(fecha.getDate()).padStart(2, '0');
            const mes = String(fecha.getMonth() + 1).padStart(2, '0'); // Los meses empiezan desde 0
            const anio = fecha.getFullYear();
            return `${dia}/${mes}/${anio}`;
        }

        // Función para mostrar todos los registros en la tabla
        function mostrarRegistros(registros) {
            const tableBody = document.getElementById("registroDatos");
            tableBody.innerHTML = ""; // Limpia cualquier dato previo en la tabla

            registros.forEach(function (registro) {
                // Formatear la fecha antes de usarla
                const fechaFormateada = formatearFecha(registro.Fecha_Registro);

                // Genera una fila por cada registro
                const row = `<tr>
                <td>${registro.Id_Tipo_Adquisicion}</td>
                <td>${registro.Descripcion}</td>
                <td>${registro.Estado ? 'Activo' : 'Inactivo'}</td>
                <td>${fechaFormateada}</td>
                <td>${registro.Usuario}</td>
                </tr>`;

                tableBody.innerHTML += row; // Agrega la fila a la tabla
            });
        }



    </script>
</body>
</html>