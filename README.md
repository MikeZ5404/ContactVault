# 🔐 Vault Electrónico de Contactos

**Vault Electrónico de Contactos** es una aplicación **Web API desarrollada con ASP.NET Core** para gestionar una agenda personal de contactos.

La aplicación permite realizar operaciones **CRUD** (Crear, Consultar, Actualizar y Eliminar), además de realizar búsquedas de contactos. La información se almacena en una base de datos **SQLite** local.

El proyecto está **contenedorizado con Docker**, permitiendo ejecutar la aplicación de forma sencilla y aislada sin necesidad de configurar manualmente el entorno de desarrollo.

---

## 🚀 Características

* ✅ Crear nuevos contactos.
* 📋 Consultar la lista de contactos.
* 🔎 Buscar contactos.
* ✏️ Actualizar información de contactos.
* 🗑️ Eliminar contactos.
* 💾 Persistencia de datos mediante SQLite.
* 🐳 Ejecución mediante Docker.
* 📖 Documentación e interacción con la API mediante Swagger.

---

## 🛠️ Tecnologías utilizadas

* **ASP.NET Core**
* **C#**
* **Entity Framework Core**
* **SQLite**
* **Swagger / OpenAPI**
* **Docker**
* **Docker Desktop**

---

## 📋 Requisitos previos

Para ejecutar este proyecto necesitas tener instalado:

* **Docker Desktop**
* Una conexión a Internet para descargar las imágenes y dependencias necesarias durante la construcción.

> **Importante:** asegúrate de que Docker Desktop esté abierto y que el motor de Docker se encuentre en ejecución antes de continuar.

---

## 📥 Instalación y ejecución

### 1. Clonar el repositorio

Clona este repositorio en tu equipo:

```bash
git clone https://github.com/MikeZ5404/ContactVault.git
```

Después, entra en la carpeta del proyecto:

```bash
cd <NOMBRE_DEL_PROYECTO>
```

> Si ya tienes el proyecto descargado, simplemente abre una terminal dentro de la carpeta raíz del proyecto.

---

### 2. Construir la imagen de Docker

Desde la carpeta raíz del proyecto, donde se encuentra el archivo `Dockerfile`, ejecuta:

```bash
docker build -t contactvault .
```

El parámetro `-t contactvault` asigna el nombre `contactvault` a la imagen.

> **Nota:** no olvides el punto (`.`) al final del comando, ya que indica que Docker debe utilizar la carpeta actual como contexto de construcción.

---

### 3. Crear y ejecutar el contenedor

Una vez finalizada la construcción de la imagen, ejecuta:

```bash
docker run -d -p 8080:8080 --name api-contactos contactvault
```

Este comando:

* `-d` → ejecuta el contenedor en segundo plano.
* `-p 8080:8080` → conecta el puerto `8080` del equipo con el puerto `8080` del contenedor.
* `--name api-contactos` → asigna el nombre `api-contactos` al contenedor.
* `contactvault` → utiliza la imagen creada anteriormente.

---

## 🌐 Acceder a la API

Con el contenedor en ejecución, abre tu navegador y accede a:

**Swagger UI:**

http://localhost:8080/swagger

Desde Swagger podrás visualizar los endpoints disponibles y realizar pruebas directamente sobre la API.

---

## 🐳 Comandos útiles de Docker

### Ver los contenedores en ejecución

```bash
docker ps
```

### Detener el contenedor

```bash
docker stop api-contactos
```

### Volver a iniciar el contenedor

```bash
docker start api-contactos
```

### Ver los registros de la aplicación

```bash
docker logs api-contactos
```

### Eliminar el contenedor

```bash
docker rm -f api-contactos
```

---

## ⚠️ Solución de problemas

### El nombre del contenedor ya está en uso

Si al ejecutar:

```bash
docker run -d -p 8080:8080 --name api-contactos contactvault
```

aparece un mensaje indicando que el nombre `api-contactos` ya está en uso, significa que ya existe un contenedor con ese nombre.

Puedes eliminarlo con:

```bash
docker rm -f api-contactos
```

Después, vuelve a ejecutar el comando para crear el contenedor:

```bash
docker run -d -p 8080:8080 --name api-contactos contactvault
```

### El puerto 8080 ya está en uso

Si el puerto `8080` ya está siendo utilizado por otra aplicación, puedes utilizar otro puerto en tu equipo. Por ejemplo:

```bash
docker run -d -p 8081:8080 --name api-contactos contactvault
```

En este caso, accederías a Swagger mediante:

```text
http://localhost:8081/swagger
```

---

## 📂 Estructura del proyecto

Una estructura aproximada del proyecto es:

```text
ContactVault/
├── Controllers/
├── Models/
├── Data/
├── Services/
├── Properties/
├── Dockerfile
├── Program.cs
├── appsettings.json
└── README.md
```

> La estructura puede variar dependiendo de la organización utilizada en el proyecto.

---

## 📌 API

La API proporciona diferentes endpoints para administrar los contactos.

Las operaciones disponibles pueden consultarse y probarse desde **Swagger UI**:

```text
http://localhost:8080/swagger
```

---

## 👨‍💻 Autor

**Miguel Sebastian Mamani Huaycho**

Proyecto desarrollado como parte de **Tecnologías Emergentes I**.

---

## 📄 Licencia

Este proyecto puede ser utilizado con fines educativos.
