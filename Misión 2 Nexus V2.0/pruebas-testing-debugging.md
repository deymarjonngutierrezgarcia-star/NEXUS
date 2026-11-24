# Documentación de Pruebas y Debugging — NEXUS (`testing-debugging`)

## 1. Pruebas de entradas inválidas
- **Nombre vacío:** Al pulsar *Iniciar* sin escribir nombre -> Debe mostrar el aviso para ingresar el nombre y no guardar partida en SQL Server.
- **Nombre de 2 caracteres (`ab`):** Al pulsar *Iniciar* -> Debe mostrar el aviso de longitud (3 a 20 caracteres) y no guardar partida.
- **Nombre de 25 caracteres:** Al pulsar *Iniciar* -> Debe mostrar el aviso de longitud (3 a 20 caracteres) y no guardar partida.

## 2. Pruebas de guardado y recuperación de partidas
- **Guardado:** Con un nombre válido de 3 a 20 caracteres (ej. `Jhonn`) al pulsar *Iniciar* -> Guarda la partida en SQL Server y muestra el ID asignado.
- **Recuperación:** Al cerrar NEXUS, volver a abrir la aplicación y recuperar la partida -> Se muestran los datos persistidos en SQL Server.

## 3. Pruebas de fallos de conexión con SQL Server
- **Escenario:** Cadena de conexión incorrecta o instancia/servicio SQL Server detenido al guardar o recuperar partida -> Se captura la excepción y se muestra un mensaje de error controlado sin que la aplicación se cierre de forma inesperada.

## 4. Defectos detectados, corrección, re-prueba e integración
- **Defecto / Ajuste:** Validación de longitud del nombre del explorador comentada/pendiente de reactivar en `Form1.cs`.
- **Corrección y re-prueba:** Se activó la validación (3 a 20 caracteres), se guardó y envió el cambio, y se repitieron las pruebas verificando que los nombres inválidos no guarden y los válidos sí guarden.
- **Integración:** Cambios verificados integrados en la rama principal.