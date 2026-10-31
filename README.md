# Proyecto 2: Creación de cuentas para estudiantes

## Datos de los integrantes

| N.º | Nombre completo            | Número |
|-----|----------------------------|--------|
| 1   | Grebel Maikors Jose Gaton  | 11     |
| 2   | Yordanis Josue Morla Feliz | 13     |

---

## Descripción de la tarea
Un centro educativo desea automatizar la creación de cuentas para sus estudiantes nuevos. Cada cuenta tendrá un nombre de usuario generado a partir de la inicial del nombre y el apellido del estudiante, convirtiendo todo el resultado a letras minúsculas. Además, se deberá validar la contraseña antes de permitir la creación de la cuenta.

## Análisis del problema

**Entrada**
- Nombre del estudiante.
- Apellido del estudiante.
- Clave o contraseña.

**Proceso**
1. Solicitar el nombre y apellido del estudiante.
2. Obtener la inicial del nombre.
3. Concatenar la inicial con el apellido.
4. Convertir el nombre de usuario generado a letras minúsculas.
5. Solicitar y validar la contraseña (mínimo 8 caracteres).
6. Si la contraseña es válida, permitir la creación de la cuenta.
7. Si no es válida, mostrar un mensaje de error.

**Salida**
- Nombre de usuario generado.
- Confirmación de cuenta creada correctamente.
- Mensaje de error si la contraseña no cumple los requisitos.

## Capturas de ejecución

**Cuenta creada correctamente**

![Cuenta creada]./(imagenes/exito.png)

**Clave inválida**

![Clave inválida]./(imagenes/error.png)

---

## Tecnologías utilizadas

| Tecnología | Descripción |
|------------|-------------|
| **C# (C Sharp)** | Lenguaje de programación utilizado para desarrollar la lógica del proyecto. |
| **Visual Studio Community** | Entorno de desarrollo integrado (IDE) utilizado para escribir, ejecutar y depurar el código. |
| **GitHub** | Plataforma utilizada para almacenar, gestionar y compartir el código fuente del proyecto. |
