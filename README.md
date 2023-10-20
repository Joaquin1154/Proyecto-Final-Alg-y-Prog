# Proyecto-Final-Alg-y-Prog
Proyecto Final realizado para la materia Algortimos y Programación 
Consigna:
Una empresa constructora tiene varias obras en ejecución y 8 grupos de obreros que trabajan en las
obras. De cada obra se conoce el nombre y dni del propietario, código interno (se lo asigna el
sistema), tipo de obra (construcción, remodelación, ampliación, etc.), el tiempo estimado de
ejecución (expresado en días), estado de avance (porcentaje), el nro de grupo de obreros asignado a
la misma y el costo. De cada obrero se almacena su nombre y apellido, dni, nro legajo, cargo
(capataz, albañil, peón, plomero, electricista, etc.) y grupo al que pertenece. De cada grupo de
obreros se conoce el código de obra en la que están trabajando (0 en caso de no estar asignado a
ninguna obra) y los integrantes.
Se deberá desarrollar una aplicación, utilizando las clases que considere necesarias, que resuelva las
funcionalidades que se muestran en el siguiente menú:
a) Contratar un obrero nuevo (se agrega a la empresa y a un grupo)
b) Eliminar un obrero (se elimina de la empresa y de su grupo)
c) Listado de obreros
d) Listado de obras
e) Agregar una obra y asignarle un grupo de obreros. Se debe verificar que haya grupo libre; en
caso contrario se debe levantar una excepción que informe lo sucedido.
f) Modificar el estado de avance de una obra. Si el estado de avance llega al 100% la obra debe
darse por finalizada, se elimina del listado de obras en ejecución y se guarda en obras
finalizadas
g) Listado de obras finalizadas.
