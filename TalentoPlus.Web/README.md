# 🚀 TalentoPlus.Web

## 🌟 Descripción General del Proyecto

**TalentoPlus.Web** es una aplicación web desarrollada con **ASP.NET Core 8.0 (MVC/Razor Pages)** que sirve como una plataforma para la gestión de empleados (basado en el esquema de tus controladores y vistas).

La aplicación está configurada para ser empaquetada y ejecutada fácilmente usando **Docker**, lo que garantiza un entorno de ejecución consistente y simplifica el despliegue.

## 🛠️ Tecnologías Utilizadas

* **Framework:** .NET 8.0 (ASP.NET Core)
* **Lenguaje:** C#
* **Contenedorización:** Docker
* **Arquitectura:** MVC (Model-View-Controller)
* **Front-end:** HTML, CSS, JavaScript (con Bootstrap y jQuery)

## 📁 Estructura del Proyecto

El proyecto sigue la estructura estándar de una aplicación ASP.NET Core MVC. Los archivos clave son:

```bash
.
├── appsettings.Development.json
├── appsettings.json
├── bin
├── Controllers
├── Dockerfile
├── Models
├── obj
├── Program.cs
├── Properties
├── README.md
├── TalentoPlus.Web.csproj
├── Views
└── wwwroot
```
---

## ⚙️ Configuración y Ejecución Local

### Prerrequisitos

Necesitas tener instalados los siguientes elementos en tu sistema:

1.  **SDK de .NET 8.0**
2.  **Docker Desktop** (

### 1. Ejecución sin Docker

Si deseas ejecutar la aplicación directamente en tu entorno local:

1.  **Clona el repositorio:**
    ```bash
    git https://github.com/Keyner23/talento-plus.git
    cd TalentoPlus.Web
    ```
2.  **Restaura las dependencias:**
    ```bash
    dotnet restore
    ```
3.  **Ejecuta la aplicación:**
    ```bash
    dotnet run
    ```
    La aplicación estará disponible en `http://localhost:[PUERTO]` (generalmente `http://localhost:5000` o el puerto especificado en `launchSettings.json`).

---

### 2. Ejecución con Docker (Método Recomendado)

Utiliza **Docker** para construir y ejecutar la aplicación dentro de un contenedor, asegurando que todas las dependencias y el entorno sean correctos.

1.  **Construye la imagen Docker:**
    Asegúrate de estar en el directorio raíz del proyecto donde se encuentra el `Dockerfile`.
    ```bash
    docker build -t talentoplus-web:latest .
    ```
    *(`-t` etiqueta la imagen con un nombre y tag)*

2.  **Ejecuta el contenedor:**
    Mapea el puerto del contenedor (típicamente 80 o 8080) al puerto deseado en tu host (e.g., 8080).
    ```bash
    docker run -d -p 8080:80 --name talentoplus talentoplus-web:latest
    ```
    *(`-d` ejecuta en modo desatendido, `-p` mapea el puerto, `--name` asigna un nombre al contenedor)*

3.  **Accede a la aplicación:**
    Abre tu navegador y navega a:
    ```
    http://localhost:8080
    ```

### Comandos Docker Útiles

* **Ver los logs del contenedor:**
    ```bash
    docker logs talentoplus
    ```
* **Detener el contenedor:**
    ```bash
    docker stop talentoplus
    ```
* **Eliminar el contenedor:**
    ```bash
    docker rm talentoplus
    ```
* **Eliminar la imagen:**
    ```bash
    docker rmi talentoplus-web:latest
    ```

