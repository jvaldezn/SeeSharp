# API de Gestión de Publicaciones de Blog

Este repositorio contiene una API en .NET para la gestión de publicaciones de blog. Está construida utilizando .NET 8 y sigue el patrón de arquitectura limpia. El proyecto utiliza diversas tecnologías y patrones de diseño para asegurar una solución robusta y escalable.

## Características

- **.NET 8:** Este proyecto está desarrollado sobre .NET 8.

- **Arquitectura Limpia:** La base del código sigue los principios de arquitectura limpia, separando las responsabilidades en capas distintas para lograr mantenibilidad y facilidad de pruebas.

- **CQRS y Mediatr:** Se utiliza la segregación de responsabilidades de comando y consulta (CQRS) junto con Mediatr para separar las operaciones de escritura y lectura, lo que hace que la aplicación sea más escalable y flexible.

- **FluentValidation:** Se utiliza FluentValidation para la validación de entradas, asegurando la integridad y seguridad de los datos.

- **IPipelineBehavior en CQRS:** Se emplean comportamientos personalizados en el pipeline para manejar preocupaciones transversales como validaciones, registros (logging) y manejo de errores.

## Cómo Empezar

Para comenzar con este proyecto, sigue estos pasos:

1. Clona el repositorio en tu máquina local:

    ```bash
    git clone https://github.com/jvaldezn/SeeSharp.git
    ```

2. Abre la solución en tu IDE preferido (Visual Studio, Visual Studio Code, etc.).

3. Configura la conexión a la base de datos en el archivo `appsettings.json`.

4. Actualiza la base de datos ejecutando:

    ```bash
    dotnet ef database update
    ```

5. Compila y ejecuta la aplicación.

6. Accede a los endpoints de la API mediante la documentación generada por Swagger/GraphQL o tu cliente de API preferido.

## Endpoints de la API

Algunos de los endpoints clave son:

- **POST /blogposts:** Crea una nueva publicación de blog.
- **GET /blogposts/{id}:** Obtiene una publicación específica por su ID.
- **GET /blogposts:** Obtiene una lista de publicaciones de blog.
- **PUT /blogposts/{id}:** Actualiza una publicación existente.
- **DELETE /blogposts/{id}:** Elimina una publicación.

Para ver la lista completa de endpoints y sus descripciones, consulta la documentación de Swagger.
