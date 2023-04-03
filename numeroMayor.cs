/* Su trabajo consiste en investigar y rellenar la línea de código que falta y que 
llama a un método de la clase Math que aceptará dos valores y devolverá el mayor 
de los dos valores en la variable largerValue, que se imprimirá en la consola.

Al ejecutar el código, debería obtener la siguiente salida: 600 

(Debemos usar metodo de la clase Math llamado Math.Max que extrae el numero mayor
de los valores declarados en las variables)*/

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);