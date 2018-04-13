# BikeRental
Test

El diseño se hizo pensando en la escalabilidad: una clase para cada tipo de alquiler, que heredan de una clase base 
y aportan metodos de calculo. Es muy sencillo agregar modalidades de alquiler mediante clases similares que implementen 
esos metodos.

En cuanto a la promocion se uso el mismo criterio, con una clase que aporta metodos estaticos para validar y calcular
el total.

Finalmente se agrego una clase para almacenar los alquileres y calcular el total de la factura.

Las practicas de diseño utilizadas fueron: 1 - Identificacion de las entidades que intervienen en el problema para diseñar
los objetos de negocio. 2 - Planteo de casos de uso para construir los métodos publicos necesarios. 3 - Analisis especifico
de cada objeto para asignar metodos privados y protegidos.

El desarrollo se hizo creando un proyecto de biblioteca en Visual Studio 2017 y agregando las clases diseñadas, 
con respaldo en GitHub.

Para las pruebas unitarias se utilizaron las facilidades de Test del Visual Studio, creando un metodo de prueba con la mayor 
cobertura posible, que finalmente resulto ser de 100%. 
