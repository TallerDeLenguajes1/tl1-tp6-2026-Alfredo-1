### 1. ¿string es un tipo por valor o un tipo por referencia?

En C#, `string` es un **tipo por referencia**. Esto significa que las variables de tipo string almacenan una referencia a la dirección de memoria en el montón (*heap*) donde se encuentran los datos reales del texto, y no el valor del texto directamente en la pila (*stack*).
Sus operadores de igualdad (`==` y `!=`) comparan los valores de los caracteres y no las direcciones de memoria.

---

### 2. ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape permiten introducir caracteres especiales o de control dentro de una cadena. Todas comienzan con una barra invertida (`\`). 

Las principales son:

| Secuencia | Carácter / Función |
| :--- | :--- |
| `\'` | Comilla simple |
| `\"` | Comillas dobles |
| `\\` | Barra invertida (backslash) |
| `\0` | Carácter nulo |
| `\a` | Alerta (sonido de notificación) |
| `\b` | Retroceso (backspace) |
| `\f` | Avance de página (form feed) |
| `\n` | Nueva línea (salto de línea) |
| `\r` | Retorno de carro |
| `\t` | Tabulación horizontal |
| `\v` | Tabulación vertical |
| `\uNNNN` | Carácter Unicode de 16 bits (4 dígitos hexadecimales) |
| `\UNNNNNNNN`| Carácter Unicode de 32 bits (8 dígitos hexadecimales) |
| `\xNN` | Carácter hexadecimal con longitud variable |

---

### 3. ¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena de texto?

* **Carácter `@` (Cadenas textuales / Verbatim strings):**
  Modifica la interpretación de la cadena para que se lea exactamente de forma literal. 
  * Desactiva el procesamiento de las secuencias de escape (por ejemplo, `\n` se imprimirá visualmente como texto en lugar de hacer un salto de línea). Esto es muy útil para escribir rutas de archivos (`@"C:\Users\Name"`) o expresiones regulares.
  * Permite escribir cadenas multilínea directamente en el código de forma visual.
  * El único carácter que requiere un escape especial dentro de una cadena `@` son las comillas dobles, las cuales se escapan duplicándolas (`""`).

* **Carácter `$` (Interpolación de cadenas / Interpolated strings):**
  Permite incrustar expresiones de C# directamente dentro de la cadena de texto utilizando llaves `{}`.
  * El compilador evalúa las variables o expresiones dentro de las llaves y las reemplaza por su representación en texto (por ejemplo: `$"Hola {nombre}"`).
  * Facilita la legibilidad del código al evitar la concatenación tradicional con el operador `+` o el uso de `String.Format()`.

* **Combinación de ambos (`$@` o `@$`):**
  A partir de C# 8.0, se pueden combinar en cualquier orden. Esto te permite tener una cadena que ignore las barras invertidas de escape (`\`) y que, al mismo tiempo, permita incrustar variables dinámicas con llaves `{}`.
