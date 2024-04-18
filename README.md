# Consigna TP WinForm
 
Se necesita una aplicaci�n para la gesti�n de art�culos de un cat�logo de un comercio. La aplicaci�n debe ser gen�rica, es decir, aplicar para cualquier tipo de comercio; y la informaci�n que en ella se cargue ser� consumida luego desde distintos servicios para ser mostradas ya sea en webs, e-commerces, apps mobile, revistas, etc. Esto no es parte del desarrollo, pero s� del contexto en el cual se utilizar� la aplicaci�n a desarrollar.
 
Deber� ser un programa de escritorio que contemple la administraci�n de art�culos. Las funcionalidades que deber� tener la aplicaci�n ser�n:
 
-   Listado de art�culos.
-   B�squeda de art�culos por distintos criterios.
-   Agregar art�culos.
-   Modificar art�culos.
-   Eliminar art�culos.
-   Ver detalle de un art�culo.
 
Toda �sta informaci�n deber� ser persistida en una base de datos ya existente (la cual se adjunta).
 
Los datos m�nimos con los que deber� contar el art�culo son los siguientes:
 
-   C�digo de art�culo.
-   Nombre.
-   Descripci�n.
-   Marca (seleccionable de una lista desplegable).
-   Categor�a (seleccionable de una lista desplegable.
-   Imagen.
-   Precio.
 
El programa debe permitir administrar las Marcas y Categor�as disponibles en el programa. Adem�s, un producto podr�a llegar a tener una o m�s im�genes, sin un l�mite establecido. Esto debe estar contemplado en la gesti�n del art�culo.
 
**Etapa 1:**  Construir las clases necesarias para el modelo de dicha aplicaci�n junto a las ventanas con las que contar� y su navegaci�n.
 
**Etapa 2:**  Construir la interacci�n con la base de datos y validaciones correspondiente para dar vida a la funcionalidad.


- Iconos Utilizados: Feather Icons
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
