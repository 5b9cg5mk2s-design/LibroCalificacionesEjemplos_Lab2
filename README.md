# Laboratorio #2 - Programación Orientada a Objetos en C#

**Fecha:** 07/09/2026

## Contenido del Repositorio

Este laboratorio tiene como objetivo introducir los conceptos fundamentales de Programación Orientada a Objetos (POO) utilizando C#. A través de tres programas progresivos se estudia la creación de clases, métodos, objetos, parámetros, constructores y propiedades.

Cada programa amplía los conocimientos adquiridos en el anterior, permitiendo comprender la encapsulación de datos y la interacción entre objetos.

## Tecnologías Utilizadas

- Lenguaje: C#
- Plataforma: .NET
- Tipo de Aplicación: Consola
- IDE: Visual Studio
- Herramientas:
  - Git
  - GitHub

---

# Programa #1 - Creación de una Clase Básica

## Descripción

Este programa introduce la definición de clases y métodos en C#.

Se crea una clase llamada `LibroCalificaciones` que contiene un método encargado de mostrar un mensaje de bienvenida al usuario.

## Conceptos Aplicados

- Creación de clases.
- Instanciación de objetos.
- Métodos públicos.
- Uso de `Console.WriteLine()`.

## Funcionamiento

1. Se crea un objeto de la clase `LibroCalificaciones`.
2. Se invoca el método `MostrarMensaje()`.
3. Se muestra el mensaje:

```text
Bienvenido al libro de calificaciones
```

## Captura de Pantalla

<img width="1476" height="276" alt="image" src="https://github.com/user-attachments/assets/c53fe8c3-caaa-4b87-bc43-ba99c7b0e8a2" />

---

# Programa #2 - Métodos con Parámetros

## Descripción

En esta práctica se amplía la funcionalidad del programa anterior incorporando parámetros en los métodos.

El usuario introduce el nombre de un curso mediante el teclado y el sistema muestra un mensaje personalizado.

## Conceptos Aplicados

- Lectura de datos mediante `Console.ReadLine()`.
- Métodos con parámetros.
- Paso de argumentos.
- Personalización de mensajes.

## Funcionamiento

1. El programa solicita el nombre de un curso.
2. El usuario introduce el nombre.
3. El método `MostrarMensaje()` recibe dicho valor como parámetro.
4. Se genera un mensaje personalizado.

### Ejemplo

```text
Por favor ingrese el nombre del curso:
Programación en C#

¡Bienvenido al libro de calificaciones para
Programación en C#!
```

## Captura de Pantalla

<img width="1477" height="377" alt="image" src="https://github.com/user-attachments/assets/948b237d-9d1f-4612-aca1-95e9a0a04c5d" />

---

# Programa #3 - Constructores y Propiedades

## Descripción

Este programa implementa conceptos más avanzados de Programación Orientada a Objetos mediante el uso de constructores y propiedades.

Se crean varios objetos de la clase `LibroCalificacionesParametro`, asignando nombres de cursos desde el constructor y permitiendo posteriormente modificar dichos valores mediante una propiedad pública.

## Conceptos Aplicados

### Constructores

Permiten inicializar el objeto al momento de crearlo.

```csharp
LibroCalificacionesParametro MyLibro =
    new LibroCalificacionesParametro("CS101 Programación en C#");
```

### Propiedades

Se utiliza la propiedad `NombreCurso` para encapsular el acceso al atributo privado.

```csharp
public string NombreCurso
{
    get { return nombreCurso; }
    set { nombreCurso = value; }
}
```

### Encapsulación

El atributo se mantiene privado y solamente puede ser accedido mediante la propiedad correspondiente.

## Funcionamiento

1. Se crean dos objetos con diferentes cursos.
2. Se muestran los nombres almacenados.
3. El usuario introduce un nuevo nombre.
4. El valor es actualizado usando la propiedad `NombreCurso`.
5. El sistema muestra el nuevo nombre almacenado.

### Ejemplo

```text
El nombre del curso es: CS101 Programación en C#
El nombre del curso es: CS102 Estructuras de datos

Por favor ingrese el nombre del curso:
Programación Orientada a Objetos

El nombre del curso es:
Programación Orientada a Objetos
```

## Captura de Pantalla

<img width="1470" height="373" alt="image" src="https://github.com/user-attachments/assets/5dcde2cb-cdb7-427f-a1f4-b4c542edf8bd" />

---

## Comparación de los Programas

| Programa | Tema Principal |
|-----------|----------------|
| Programa 1 | Clases y métodos |
| Programa 2 | Métodos con parámetros |
| Programa 3 | Constructores y propiedades |

---

## Estructura de Carpetas o Directorios

```plaintext
Laboratorio2/
│
├── AplicacionLibroCalificaciones_1/
│   ├── LibroCalificaciones.cs
│   └── PruebaLibroCalificaciones_1.cs
│
├── AplicacionLibroCalificaciones_2/
│   ├── MiLibroCalificaciones.cs
│   └── LibroPruebaCalificaciones.cs
│
├── AplicacionLibroCalificaciones_3/
│   ├── LibroCalificacionesParametro.cs
│   └── PruebaLibroCalificacionesParametro.cs
│
└── README.md
```

## Instrucciones de Ejecución / Uso

### 1. Clonar el repositorio

```bash
git clone [URL_DEL_REPOSITORIO]
```

### 2. Abrir el proyecto

Abrir la solución correspondiente en Visual Studio.

### 3. Compilar el proyecto

```text
Build > Build Solution
```

### 4. Ejecutar

```text
Ctrl + F5
```

o

```text
F5
```

### 5. Probar cada programa

- Programa 1: Mensaje de bienvenida.
- Programa 2: Ingreso de nombre del curso.
- Programa 3: Creación y modificación de cursos mediante propiedades.

---

## Aprendizajes Obtenidos

Durante este laboratorio se reforzaron los siguientes conceptos:

- Creación de clases.
- Creación e instanciación de objetos.
- Métodos.
- Métodos con parámetros.
- Lectura de datos desde consola.
- Constructores.
- Propiedades.
- Encapsulación.
- Programación Orientada a Objetos.

---

## Autor y Contexto

- Nombre: Johandry González
- Institución: Universidad Tecnológica de Panamá (UTP)
- Asignatura: Herramientas de programación aplicadas 3
- Laboratorio: Programación Orientada a Objetos en C#
- Fecha de Realización: 07/09/2026

---

## Referencias

- Contenido brindado por el profesor.
