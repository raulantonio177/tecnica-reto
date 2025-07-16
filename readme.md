# Weighted Uniform Strings

Este repositorio contiene la descripción de un ejercicio de programación diseñado para evaluar a candidatos a desarrollador full stack.

---

## Descripción del ejercicio

Una **cadena ponderada** es una secuencia de letras minúsculas (`a`–`z`), donde a cada carácter se le asigna un peso numérico:

- `a` = 1, `b` = 2, `c` = 3, …, `z` = 26.

Una **subcadena uniforme** es una secuencia contigua de un mismo carácter repetido. Por ejemplo:

- Válidas: `"ccc"`, `"a"`, `"dddd"`.
- No válidas: `"aba"`, `"abc"`.

El **peso** de una subcadena uniforme se calcula como la suma de los pesos de sus caracteres. Por ejemplo, para la subcadena `"ccc"` (peso de `c` = 3), el peso total es `3 + 3 + 3 = 9`.

### Objetivo

1. Dada una cadena de entrada `s` y un conjunto de consultas (lista de enteros) `queries`, primero determinar **todas** las subcadenas uniformes contiguas posibles en `s` y calcular su peso.
2. Construir el conjunto `U` con todos los pesos obtenidos.
3. Para cada valor `q` en `queries`, devolver:
   - **"Yes"** si `q ∈ U`.
   - **"No"** en caso contrario.

### Ejemplo ilustrativo

```text
s = "abbcccdddd"
queries = [1, 7, 5, 4, 15]

Subcadenas uniformes y sus pesos:
- "a"               → 1
- "b", "bb"       → 2, 4
- "c", "cc", "ccc" → 3, 6, 9
- "d", "dd", "ddd", "dddd" → 4, 8, 12, 16

Conjunto U = { 1, 2, 3, 4, 6, 8, 9, 12, 16 }

Respuestas para `queries`:
- 1  → Yes
- 7  → No
- 5  → No
- 4  → Yes
- 15 → No
```

### Ejemplos adicionales

#### Ejemplo 1: Cadena con un solo carácter
```text
s = "aaaaa"
queries = [1, 2, 3, 4, 5, 6]

Subcadenas uniformes:
- "a", "aa", "aaa", "aaaa", "aaaaa" → 1, 2, 3, 4, 5

Conjunto U = { 1, 2, 3, 4, 5 }

Respuestas:
- 1 → Yes, 2 → Yes, 3 → Yes, 4 → Yes, 5 → Yes, 6 → No
```

#### Ejemplo 2: Caracteres alternados
```text
s = "ababab"
queries = [1, 2, 3]

Subcadenas uniformes:
- "a", "b", "a", "b", "a", "b" → 1, 2, 1, 2, 1, 2

Conjunto U = { 1, 2 }

Respuestas:
- 1 → Yes, 2 → Yes, 3 → No
```

#### Ejemplo 3: Valores grandes
```text
s = "zzzz"
queries = [26, 52, 78, 104, 130]

Subcadenas uniformes:
- "z", "zz", "zzz", "zzzz" → 26, 52, 78, 104

Conjunto U = { 26, 52, 78, 104 }

Respuestas:
- 26 → Yes, 52 → Yes, 78 → Yes, 104 → Yes, 130 → No
```

---

## Estructura del proyecto

```plaintext
README.md                                    # Descripción del ejercicio
src/                                         # Carpeta para código de la solución
  WeightedUniformStrings.Core/              # Librería principal con la implementación
tests/                                       # Carpeta para pruebas unitarias
  WeightedUniformStrings.Tests/              # Proyecto de pruebas con xUnit
```

---

## Requisitos técnicos

- **Framework**: .NET 8
- **Lenguaje**: C#
- **Framework de pruebas**: xUnit
- **IDE recomendado**: Visual Studio 2022 o Visual Studio Code

---

## Instrucciones de uso

1. **Clona este repositorio**:
   ```bash
   git clone <url-del-repositorio>
   cd "Uniform Weight Strings"
   ```

2. **Restaura las dependencias**:
   ```bash
   dotnet restore
   ```

3. **Ejecuta las pruebas**:
   ```bash
   dotnet test
   ```

4. **Compila la solución**:
   ```bash
   dotnet build
   ```

---

## Casos de prueba incluidos

El proyecto incluye 15 pruebas unitarias que cubren los siguientes escenarios:

1. **Ejemplo oficial** - Caso base del problema
2. **Todo un carácter** - Cadena con repetición del mismo carácter
3. **Caracteres alternados** - Patrón alternado sin repeticiones
4. **Cadena vacía** - Manejo de entrada vacía
5. **Consulta vacía** - Lista de consultas vacía
6. **Valores grandes** - Caracteres con peso alto (z)
7. **Subcadenas de longitud uno** - Solo caracteres individuales
8. **Consulta no existente** - Valores que no están en el conjunto
9. **Consulta límite inferior** - Valores en el límite mínimo
10. **Consulta límite superior** - Valores grandes y límites
11. **Intercalado con repetidos** - Patrón mixto
12. **Todos los caracteres** - Alfabeto completo
13. **Consulta negativa** - Valores negativos y cero
14. **Consulta con valores grandes y pequeños** - Rango amplio de valores

---

## Consideraciones de implementación

### Complejidad temporal
- **Tiempo**: O(n + m) donde n es la longitud de la cadena y m es el número de consultas
- **Espacio**: O(n) para almacenar el conjunto de pesos únicos

### Restricciones
- La cadena de entrada solo contiene letras minúsculas (a-z)
- Las consultas pueden ser cualquier entero
- La longitud de la cadena puede ser hasta 10^5
- El número de consultas puede ser hasta 10^5

### Casos edge a considerar
- Cadena vacía
- Lista de consultas vacía
- Caracteres repetidos consecutivos
- Consultas con valores negativos o cero
- Consultas con valores muy grandes
- Caracteres con peso máximo (z)

---

## Evaluación

La solución será evaluada considerando:

1. **Correctitud**: Todas las pruebas unitarias deben pasar
2. **Eficiencia**: Complejidad temporal y espacial óptima
3. **Legibilidad**: Código limpio y bien documentado
4. **Manejo de casos edge**: Comportamiento correcto en casos límite
5. **Estructura del proyecto**: Organización adecuada del código

---

¡Éxito con el ejercicio!

