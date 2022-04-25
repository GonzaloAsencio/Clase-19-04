# 19-04-Abril
Ejemplos  de distintas formas de crear un meotdo y como utlizar los getter y setter


TEORIA:

Constructores

Para crear una INSTANCIA de una clase se utilizan los llamados
«Constructores«, funciones que nos permiten ingresar los datos del objeto y
nos devuelven como resultado la referencia del objeto creado.
Luego para construir el objeto se usa la instrucción «new», por ejemplo, de esta
forma:
Gato unGato = new Gato («Charles», Color.white);
Esto creará un objeto de la clase Gato con nombre «Mariano» color blanco y
la referencia del objeto la tendremos almacenada en el campo «unGato».

Setters & Getters

Los Setters & Getters son métodos de acceso lo que indica que son siempre
declarados públicos, y nos sirven para dos cosas:

Setters: Del Inglés Set, que significa establecer, pues nos sirve para asignar un
valor inicial a un atributo, pero de forma explícita, además el Setter nunca retorna
nada (Siempre es void), y solo nos permite dar acceso público a ciertos atributos
que deseemos el usuario pueda modificar.

Getters: Del inglés Get, que significa obtener, pues nos sirve para obtener
(recuperar o acceder) el valor ya asignado a un atributo y utilizarlo para cierto
