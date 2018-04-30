# NumerosPerfectos

Son aquellos números naturales que tienen la propiedad de ser iguales a la suma de sus divisores propios.
Así, por ejemplo, el número 6 (1+2+3=6) es un número perfecto. Los números perfectos pares están dados 
por la siguiente expresión, conocida como Teorema de Euclides-Euler:

        n = (2^(n-1))((2^n) – 1)

En la que el término 2n – 1 debe ser un número primo.


El siguiete codigo consiste en recorrer una serie de números (2 al 11) en este caso, 
y por cada número sustituir su valor en el segundo término del Teorema, 
el número resultante será evaluado para determinar si es primo. Si el numero resulta
primo se cumple el requisito para que el teorema de Euclides genere un numero perfecto. 
Se aplica tomanto como parametro el numero que se uso para obtener un numero primo a traves
del segundo termino y se obtiene el numero perfecto.
Luego muestran los divisores para constatar que sea un numero perfecto. 

Nota se pueden evaluar cualquier cantidad de numeros pero cada numero perfecto
a partir del 6 numero aumenta considerablemente su extencion
