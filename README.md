# DeepNote APP
App para tomar notas, simple y sencilla, no v�lida para el uso diario, proyecto en desarrollo.

## Estructra de ficheros
Cada componente se organiza en distintas carpetas dependiendo de su utilidad.

- `Controllers:` En este direcotrio se disponen las clases encargadas de la logica de la aplicaci�n.
- `Models:` Modelos usados por la logica.
- `Resources:` Recursos usados en la app, estilos, iconos...
	- `ButtonStyles:` Diccionarios de recursos `(Style)` para los botones.
	- `Icons:` Iconos usado en la App.
	- `TextBoxStyles:` Diccionarios de recursos `(Style)` para los `TextBox` y los `PasswordBox`.
- `Views:` Vistas de la aplicaci�n, ventanas y demas cosas graficas.
	- `Home:` Ventana principal de la app, no confundir con la ventana de inicializaci�n.
	- `Login:` Ventana de inicio de sesi�n.
	- `Register:` Ventana de registro de usuarios.

## Utilidad de la app
*Ninguna*, actualmente esa app esta en desarrollo y no tiene una funcionalidad practica, pero la idea principal,
es el de la tipica app de notas b�sica.

##Caracteristicas de la APP
- [x] Creamos 2 constructores para una misma clase
- [x] Usamos los getter y setter b�sicos y otros personalizados
- [x] Realizamos la sobrecarga de alg�n m�todo
- [x] Manejamos componentes b�sicos
- [] Manejamos componentes avanzados (tienen configuraciones que modificar)
- [] Usamos distintos tipos de listas de objetos dependiendo de su uso (List, ObservableCollection...) x2
- [] Usamos eventos diferentes del b�sico del componente x2
- [] Realizamos alg�n Binding entre 2 componentes gr�ficos
- [] Indicamos que archivo es el origen de datos de nuestra ventana
- [] Realizamos Binding entre un componente y un objeto
- [] Usamos DataGrid para mostrar informaci�n. Sin personalizar la salida.
- [] �dem pero configur�ndolo con DataGrid.Columns x3
- [] Somos capaces de conseguir que el DataGrid (o el componente que sea) se actualice, no solo con la inclusi�n/eliminaci�n de nuevos elementos, sino tambi�n al cambiar alguna propiedad de alguno de ellos. (INotifyPropertyChanged) x4
- [x] Usamos una 2� ventana
- [] Utilizamos correctamente distintos espacios de nombres, separamos las clases seg�n su prop�sito (gui, datos, l�gica...)
- [] Accedemos a las posiciones de un Array con la sintaxis objetoArray[posicion] x3
- [] Utilizamos el interfaz ICloneable para manejar informaci�n temporal (no tocamos el objeto que hemos clonado) x3
- [] Usamos IDataErrorInfo para validar campos incluyendo NotifyOnValidationError y ValidatesOnDataErrors x4
- [] Asociamos una funci�n a la validaci�n de alg�n campo. x4
