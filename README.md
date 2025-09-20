# PatronComposite
# Ejemplo del Patrón de Diseño Composite

Este repositorio contiene un proyecto de demostración que implementa el **Patrón de Diseño Composite**, uno de los patrones creacionales de la **Gang of Four (GoF)**. Fue creado como parte de un trabajo práctico para la materia de Metodología de Sistemas II De la tecnicatura Universitaria en Programacion de la UTN.

## Objetivo del Proyecto

El objetivo principal es ilustrar cómo el patrón Composite resuelve el problema de manejar objetos individuales y grupos de objetos de manera uniforme. En este ejemplo, se modela una jerarquía de estudiantes y grupos de estudiantes, permitiendo realizar operaciones como el cálculo de promedios de forma consistente en todos los niveles.

## Estructura del Patrón

El patrón está implementado a través de las siguientes clases:

* **`IParticipante.cs`**: La interfaz del **Componente**. Define las operaciones comunes, como `getNombre()` y `getPromedio()`, que son implementadas por todas las clases en la jerarquía.
* **`Estudiante.cs`**: La clase **Hoja (Leaf)**. Representa un objeto individual (un estudiante) que no contiene otros elementos.
* **`GrupoEstudiantes.cs`**: La clase **Compuesto (Composite)**. Contiene una colección de objetos `IParticipante` (ya sean estudiantes o subgrupos), permitiendo crear la estructura de árbol.

## Cómo ejecutar el proyecto

Este es un proyecto de consola de C#. Para ejecutarlo, necesitas tener Visual Studio 2022 instalado.

1.  Clona el repositorio en tu máquina local.
2.  Abre el archivo de la solución (`.sln`) en Visual Studio.
3.  Ejecuta el proyecto (`Ctrl + F5` o desde el menú **Depurar > Iniciar sin depurar**).

La salida se mostrará en la consola, demostrando el cálculo de promedios para los grupos y subgrupos.
