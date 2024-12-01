# Inventory System

This is an inventory management system built with ASP.NET Core and Entity Framework Core.

## Features

- View all products in the inventory
- Add new products to the inventory
- Edit existing products in the inventory
- Delete products from the inventory

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET 8.0 or later
- A suitable IDE such as JetBrains Rider 2023.1.2
- Entity Framework Core 6.0.0 or later

### Running the application

1. Move to the root directory of the project
```bash
cd InventorySystem
```

2. Migrate models to the database by running the following command:

```bash
dotnet ef database update
```

3. Build the application by running the following command:

```bash
dotnet build
```

4. Run the following command to start the application:

```bash
dotnet run
```

3. Open a web browser and navigate to `https://localhost:5209`
4. You should see the home page of the application


## Built With

- [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) - The web framework used
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - The Object-Relational Mapping (ORM) framework used

## Authors

- **HolisticDevelop** - *Initial work* - [HolisticDevelop](https://github.com/HolisticDevelop)
  
## Registro de Productos
Como administrador del sistema,
Quiero poder registrar nuevos productos en el inventario,
Para que pueda mantener actualizada la información sobre los artículos disponibles y sus cantidades.

El sistema debe permitir ingresar el nombre del producto, descripción, categoría, precio y cantidad inicial.
Debe haber validaciones para evitar duplicados en el registro.
El sistema debe confirmar el registro exitoso del producto.

## Actualización de Stock
Como empleado del almacén,
Quiero poder actualizar las cantidades de stock de los productos,
Para que la información del inventario refleje con precisión los niveles actuales de existencias.

El sistema debe permitir la actualización de la cantidad de productos en stock.
Debe haber una opción para registrar entradas y salidas de inventario.
El sistema debe mostrar un mensaje de confirmación tras la actualización.

## Consulta de Inventario
Como gerente de operaciones,
Quiero poder consultar el inventario en tiempo real,
Para que pueda tomar decisiones informadas sobre reabastecimiento y gestión de productos.

El sistema debe ofrecer una vista general del inventario con filtros por categoría, proveedor y estado del producto.
Debe mostrar la cantidad disponible, la cantidad mínima y la ubicación del producto en el almacén.
La consulta debe ser rápida y accesible desde un panel principal.

## Generación de Reportes
Como administrador del sistema,
Quiero poder generar reportes de inventario,
Para que pueda analizar las tendencias de ventas y el rendimiento del inventario.

El sistema debe permitir la generación de reportes por rango de fechas, categorías de productos y niveles de stock.
Los reportes deben ser exportables en formatos como PDF y Excel.
Debe haber un resumen visual de las métricas clave, como productos más vendidos y niveles de stock críticos.

## Notificaciones de Reabastecimiento
Como empleado de gestión de inventario,
Quiero recibir notificaciones cuando un producto esté por debajo del nivel mínimo de stock,
Para que pueda realizar pedidos de reabastecimiento a tiempo y evitar faltantes.

El sistema debe permitir establecer niveles mínimos de stock para cada producto.
Debe enviar alertas por correo electrónico o a través de la aplicación cuando se alcance el nivel mínimo.
Las notificaciones deben incluir información sobre el producto y la cantidad recomendada para reabastecer.
