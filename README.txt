# pruebaNewshore

Para la prueba realizada es necesario descargar el repositorio el cual contiene dos proyectos Front y Back,
el proyecto front llamado "FrontPrueba" es necesario installar los paquetes necesarios con "npm install" y ejecutar con "ng serve".

para el proyecto back llamado "BackPrueba" realizo con .net versión 6, el cual tiene las siguientes capas:
- Api: Controlador
- Managers: Manejador de la logica
- Repositories: consulta de los datos 
- Services: servicio de consumo de la api con singleton
- Data: acceso a los datos guardados

En el archivo de configuración llamado "appsettings.json", el cual estan las siguientes variable:
API_URL: URL del api para consumir los vuelos ofrecidos la cual esta configurada para el mas complejo.
MAX_JOURNEY: Número maximo de vuelos en una busqueda realizada, la cual esta configurada inicialmente para 3.