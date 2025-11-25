# 🚗 Proyecto Concesionaria 

Aplicación de consola en C# diseñada para consolidar los pilares de la Programación Orientada a Objetos (POO) avanzada y el manejo de colecciones dinámicas.

El programa simula el inventario de una concesionaria, demostrando cómo objetos diferentes pueden ser tratados como un solo tipo.

---

## 🛠️ Conceptos Clave Demostrados

| Concepto | Explicación | Archivos |
| :---: | :--- | :--- |
| **Herencia y Abstracción** | Uso de `abstract class Vehiculo` como plantilla base para evitar la duplicidad de código. | `Vehiculo.cs` |
| **Polimorfismo** | Capacidad de la `List<Vehiculo>` de almacenar `Auto`, `Moto` y `Camioneta` y llamar a su `MostrarDatos()` respectivo. | `Program.cs` |
| **Interfaces** | Implementación del contrato `ICargable` para otorgar la habilidad `Cargar()` solo a la clase `Camioneta`. | `ICargable.cs`, `Camioneta.cs` |
| **Propiedades Get/Set** | Uso de propiedades autoimplementadas (`{ get; set; }`) para encapsular datos. | `Vehiculo.cs`, `Auto.cs`, etc. |
| **Listas Genéricas** | Uso de `List<T>` para un manejo dinámico y flexible del inventario. | `Program.cs` |

---

## 💻 Instrucciones de Ejecución

Este proyecto corre en la consola de .NET.

1.  Clonar el repositorio:
    ```bash
    git clone [https://docs.github.com/es/repositories/creating-and-managing-repositories/quickstart-for-repositories](https://docs.github.com/es/repositories/creating-and-managing-repositories/quickstart-for-repositories)
    ```
2.  Abrir el archivo `.sln` en Visual Studio.
3.  Ejecutar la aplicación (F5). El programa mostrará las fichas técnicas de cada vehículo, llamando a la implementación única de `MostrarDatos()` para cada clase.

---

## 📸 Captura de Pantalla
<img width="1471" height="721" alt="image" src="https://github.com/user-attachments/assets/8e980af9-74ea-4c0d-8172-0189439c4c6a" />

<img width="1492" height="756" alt="image" src="https://github.com/user-attachments/assets/1034f8c0-8bf8-467a-861a-2370f4b1dc48" />






