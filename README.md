# Prueba Técnica Amaris Consulting - Repositorio de Manuel Castillo

Este repositorio contiene la prueba técnica realizada por Manuel Castillo para optar al cargo de desarrollador en Amaris Consulting.

## Descripción del Proyecto

El objetivo de este proyecto es realizar pruebas técnicas para el puesto de desarrollador en Amaris Consulting. El código está desarrollado utilizando Visual Studio 2022, con el framework .NET Core 7.0.

### Estructura del Proyecto

El proyecto sigue una arquitectura basada en el patrón MVC (Modelo-Vista-Controlador) con la siguiente estructura:

- **Capa de Datos**: Esta capa maneja el acceso a datos, pero debido a que el consumo de un API REST con datos dummy, no se requiere una conexión a una base de datos tradicional. En su lugar, se utiliza una capa de repositorio con una interfaz pública de repositorio que se conecta mediante HTTPGet a los servicios de consulta del API.

- **Capa de Negocios**: Aquí se encuentran las lógicas y reglas de negocio. Esta capa es responsable de procesar los datos obtenidos de la capa de datos y aplicar las reglas definidas para presentar los resultados adecuados a la capa de presentación.

- **Capa de Comunicación**: La capa de comunicación maneja la interacción con el API REST de datos dummy. Aquí se definen las clases y métodos necesarios para realizar las peticiones y obtener los datos requeridos.

- **Capa de Presentación**: Esta capa contiene los elementos visuales del proyecto, incluyendo vistas, controladores y recursos estáticos. Se utiliza el framework Bootstrap para crear un diseño responsive y amigable para diferentes dispositivos.

## Uso del API Rest de Datos Dummy

Es importante tener en cuenta que los servicios de consulta del API REST tienen un límite de uso. Si se realizan múltiples peticiones consecutivas, puede mostrar un error debido a exceso de peticiones. Se recomienda dejar un tiempo de ejecución de al menos 1 minuto entre cada petición para evitar problemas.

## Pruebas Unitarias

Adicionalmente, se han implementado pruebas unitarias utilizando el proyecto MS Unit Test .NET Core (MSTest) para garantizar el correcto funcionamiento del código y la calidad del software desarrollado.

## Requisitos del Entorno

- Visual Studio 2022 o una versión compatible.
- .NET Core 7.0 o posterior.
- Conexión a Internet para acceder al API REST de datos dummy.

## Contribuciones

Este repositorio ha sido creado con fines de evaluación para la prueba técnica de Amaris Consulting y, por lo tanto, no aceptaremos contribuciones externas en este momento. Agradecemos tu comprensión.

## Contacto

Si tienes alguna pregunta o inquietud relacionada con este proyecto o el proceso de selección, puedes contactar a Manuel Castillo en manuelcastillo10@gmail.com.

¡Gracias por revisar este proyecto!
