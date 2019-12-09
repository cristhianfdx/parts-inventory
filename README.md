# Sistema de Inventario de Repuestos Electrónicos

Nota: El proyecto fue realizado con Visual Studio 2010 - Net framework 4.0

El proyecto a presentar para la asignatura es un inventario de repuestos electrónicos, donde los
usuarios puedan crear y gestionar repuestos dentro del inventario, se maneja un stock de
repuestos donde se pueden hacer entradas y salidas de los mismos.
El proyecto se implementa para cubrir la necesidad de tener organizado un stand de repuestos
mediante un software que gestione la ubicación y la descripción de los mismos dentro de una
tienda por ejemplo.


## Requerimientos y lógica de negocio del proyecto planteado
1. El sistema cuenta con gestión de usuarios, donde existe un rol de administrador y uno
básico
2. El sistema permite realizar login en la aplicación
3. El usuario con rol de administrador tiene permisos privilegiados, los cuales le permite:
- Crear, actualizar, eliminar y listar todos los usuarios
- Crear, actualizar, eliminar y listar todos los repuestos
- Gestionar el stock de repuestos, realizar ingresos, salidas, y editar repuestos
Crear, actualizar, eliminar y listar todos las marcas de repuestos
4. El usuario con rol básico puede realizar las siguientes acciones:
- Gestionar el stock de repuestos, realizar ingresos, salidas
- Listar todos los repuestos
5. El sistema guarda en la base de datos las contraseñas encriptadas
6. El motor de base de datos en el cual se almacenan los datos es MYSQL
7. El sistema tiene validaciones de campos en cada formulario, se utilizan expresiones regulares
para tal fin.
8. El sistema no permite eliminar al usuario con rol administrador ya que solo se tiene uno.
9. No se podrán eliminar repuestos que se encuentren en el stock hasta que se haga su salida.
10. Las imágenes de los productos serán guardadas en el equipo y no en la base de datos.11. La base de datos solo contiene la ruta de las imágenes para ahorrar espacio.
12. Para mayor seguridad y evitar la inyección SQL, todas las consultas a la base de datos se
manejan mediante procedimientos almacenados.
13. El software de la aplicación utiliza la arquitectura de N-CAPAS (Capa de datos, Capa de
negocio, Capa Entidad, Capa presentación).
14. El sistema guarda las contraseñas de usuario con encriptación.

## Modelo entidad relación

![Screenshot from 2019-06-05 16-41-34](https://user-images.githubusercontent.com/40704923/58992573-d049c480-87b0-11e9-8196-4f847a3fbc7d.png)

## Screenshoot

![Screenshot from 2019-06-05 16-44-24](https://user-images.githubusercontent.com/40704923/58992721-35051f00-87b1-11e9-965f-5841052ac3ad.png)

