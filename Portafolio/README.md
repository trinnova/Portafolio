.NET o DONET
Es una plataforma que sirve para desarrollar distintos tipos de aplicaciones.
DESKTOP, WEB, MOVILE, JUEGOS.
Se creo por Microsoft en 2002 para correr en Windows.
.NET llego a la versi�n 4.8, se le conoce como: .NET framework.
.NET CORER es la versi�n nueva, sali� en 2016, pasaron de: .NET CORE 3, pas� a la versi�n .NET 5
y dejaron de llamarle .NET CORE, qued� como: .NET.

�Qu� es C#?
Es un lenguaje multiparadigma.
Podemos desarrollar: WEB, MOVILE, DESKTOP, JUEGOS...
Es un lenguaje tipado y basado en clases.
NOs permite trabajar con funciones de primera clase.
LINQ y expresiones lambda.

�Qu� es ASP-NET CORE?
Framework para aplicaciones WEB.
ASP, Significa: ACTIVE SERVER PAGES.
Sistem de ruteo, sistema de usuarios, inyecci�n de dependencias, velocidad.

MVC: Modelo, Vista, Controlador.
Modelo: se refiere a la data de nuestra app.
Vista: se refiere a la plantilla que muestra la data de un modelo.
Controlador: se encarga de actualizar los modelos y le pasa los datos a la vista
para que muestre el contenido final al usuario.

RAZOR PAGES:
Todo lo que haces en MVC, lo puedes hacer en Razor.
El que recibe la petici�n es un page hadler (manejador de p�gina(.

WEBAPIS:
Usamos cuando queremos generar interfaces de usuario.
Si lo ponemos en t�rminos de MVC, una WEBAPI elimina la VISTA.
Puedes combinar MVC con WEB APIS.


BLAZOR:
Envia c�digo C# al navegador del usuario.
Es una tecnolog��a de ASP.NET CORE que nos permite crear aplicaciones web interactivas.
Con Blazor WebAssembly podemos enviar el c�digo de c# al navegador del usuario
y ejecutarlo ah� mismo.
Blazor ejecuta la app remotamente desde un servidor.

gRPC:
Es un framework que permite hacer llamadas de procedimiento remoto.
Nos permite comunicarnos de una manera muy r�pida entre distintas apps.

Crear proyecto: ASP.NET CORE WEB APP

Crear proyecto con DONET:
Abrimos POWERSHELL
donet new --LIST
donet new mvc -o- nombreCarpeta/NombreProyecto
Corre la APP:
donet run