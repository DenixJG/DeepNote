# DeepNote APP
App para tomar notas, simple y sencilla, no válida para el uso diario, proyecto en desarrollo.

## Estructra de ficheros
Cada componente se organiza en distintas carpetas dependiendo de su utilidad.

- `Controllers:` En este direcotrio se disponen las clases encargadas de la logica de la aplicación.
- `Models:` Modelos usados por la logica.
- `Resources:` Recursos usados en la app, estilos, iconos...
	- `ButtonStyles:` Diccionarios de recursos `(Style)` para los botones.
	- `Icons:` Iconos usado en la App.
	- `TextBoxStyles:` Diccionarios de recursos `(Style)` para los `TextBox` y los `PasswordBox`.
	- `ComboBoxStyles:` Diccionarios de recursos `(Style)` para `ComboBox`.
- `Views:` Vistas de la aplicación, ventanas y demas cosas graficas.
	- `Home:` Ventana principal de la app, no confundir con la ventana de inicialización.
	- `Login:` Ventana de inicio de sesión.
	- `Register:` Ventana de registro de usuarios.
    
## Utilidad de la app
**Ninguna**, actualmente esa app esta en desarrollo y no tiene una funcionalidad practica, pero la idea principal,
es el de la tipica app de notas básica.

## Caracteristicas de la APP
- [x] Creamos 2 constructores para una misma clase
- [x] Usamos los getter y setter básicos y otros personalizados
- [x] Realizamos la sobrecarga de algún método
- [x] Manejamos componentes básicos
- [x] Manejamos componentes avanzados (tienen configuraciones que modificar)
- [x] Usamos distintos tipos de listas de objetos dependiendo de su uso (List, ObservableCollection...) x2
- [x] Usamos eventos diferentes del básico del componente x2
- [ ] Realizamos algún Binding entre 2 componentes gráficos
- [ ] Indicamos que archivo es el origen de datos de nuestra ventana
- [ ] Realizamos Binding entre un componente y un objeto
- [ ] Usamos DataGrid para mostrar información. Sin personalizar la salida.
- [ ] Ídem pero configurándolo con DataGrid.Columns x3
- [ ] Somos capaces de conseguir que el DataGrid (o el componente que sea) se actualice, no solo con la inclusión/eliminación de nuevos elementos, sino también al cambiar alguna propiedad de alguno de ellos. (INotifyPropertyChanged) x4
- [x] Usamos una 2ª ventana
- [x] Utilizamos correctamente distintos espacios de nombres, separamos las clases según su propósito (gui, datos, lógica...)
- [ ] Accedemos a las posiciones de un Array con la sintaxis objetoArray[posicion] x3
- [ ] Utilizamos el interfaz ICloneable para manejar información temporal (no tocamos el objeto que hemos clonado) x3
- [ ] Usamos IDataErrorInfo para validar campos incluyendo NotifyOnValidationError y ValidatesOnDataErrors x4
- [ ] Asociamos una función a la validación de algún campo. x4
