# PruebaCabeceraYDetalles
Autor: Carlos Cristobal Torres Carballo.

Pasos para que funcione en tu repositorio
-  Descargar el repositorio en tu ordenador.
-  Modifica la Cadena de Conexion en el archivo web.config, y pon tu instancia de SQL SERVER o la base de datos que utiliza
-  Ejecuta las migraciones, para hacer eso:
    - En el Visual Studio, ve a Herramientas/Administrador de Paquetes Nuget/Consola del Administrador De Paquetes
    - Ejecuta los siguientes Comandos: 
      - update-database
    - Si no funciona nada, verifica la conexion o vuelve a crear una migracion con:
      - enable-migrations
      - add-migration init
      - update-database
- Una vez hecho lo anterior ya podras usar las peticiones, Por los Productos y las personas no se preocupe, en la migracion se carga esos datos

Saludos :D
