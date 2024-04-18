# Consigna TP WinForm

Se necesita una aplicación para la gestión de artículos de un catálogo de un comercio. La aplicación debe ser genérica, es decir, aplicar para cualquier tipo de comercio; y la información que en ella se cargue será consumida luego desde distintos servicios para ser mostrada ya sea en webs, e-commerces, apps mobile, revistas, etc. Esto no es parte del desarrollo, pero sí del contexto en el cual se utilizará la aplicación a desarrollar.

Deberá ser un programa de escritorio que contemple la administración de artículos. Las funcionalidades que deberá tener la aplicación serán:

-   Listado de artículos.
-   Búsqueda de artículos por distintos criterios.
-   Agregar artículos.
-   Modificar artículos.
-   Eliminar artículos.
-   Ver detalle de un artículo.

Toda esta información deberá ser persistida en una base de datos ya existente (la cual se adjunta).

Los datos mínimos con los que deberá contar el artículo son los siguientes:

-   Código de artículo.
-   Nombre.
-   Descripción.
-   Marca (seleccionable de una lista desplegable).
-   Categoría (seleccionable de una lista desplegable).
-   Imagen.
-   Precio.

El programa debe permitir administrar las Marcas y Categorías disponibles en el programa. Además, un producto podría llegar a tener una o más imágenes, sin un límite establecido. Esto debe estar contemplado en la gestión del artículo.

**Etapa 1:**  Construir las clases necesarias para el modelo de dicha aplicación junto a las ventanas con las que contará y su navegación.

**Etapa 2:**  Construir la interacción con la base de datos y validaciones correspondiente para dar vida a la funcionalidad.

---

- **Iconos Utilizados:** Feather Icons
[Figma con Iconos](https://www.figma.com/file/SrqzxLyyNF0paaJaEuNFNS/TPWinForm?type=design&node-id=1:2104&mode=design&t=3NzGvJcjVbpzR9XY-1)

## Paleta de Colores

- Form BackColor: 244, 245, 250
- Default Font Color: 87, 89, 91

### Primary Button 
- BackColor: 95, 105, 245
- Border: None
- ForeColor: White

### Secondary Button 
- BackColor: Transparent
- Border: 95, 105, 245
- BorderSize: 2
- ForeColor: 95, 105, 245

### Round Panel
- BackColor: White
- BorderColor: 236, 236, 238
- BorderWidth: 3
- Radius: 10

### TextBox
- BorderStyle: FixedSingle
- BackColor: 246, 247, 251

## Formato y Estilo

Se recomienda seguir estas convenciones para lograr un código legible y consistente que facilite la lectura para todos los desarrolladores del equipo. Esto mejora la detección de errores y la interpretación de las funciones de cada elemento del código.

| Nombre Objeto             | Notación   | Guion Bajo |
|:--------------------------|:-----------|:----------:|
| Nombre Namespace          | PascalCase | No         |
| Nombre Clase              | PascalCase | No         |
| Nombre Constructor        | PascalCase | No         |
| Nombre Método             | PascalCase | No         |
| Argumentos de un Método   | camelCase  | No         |
| Variables Locales         | camelCase  | No         |
| Nombre de Constantes      | PascalCase | No         |
| Nombre Atributo Público   | PascalCase | No         |
| Nombre Atributo Privado   | _camelCase | Sí         |
| Nombre de Propiedades     | PascalCase | No         |
| Nombre de Enum type       | PascalCase | No         |
