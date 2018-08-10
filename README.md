# fe-hacienda-cr-dotnet
Implementación y herramientas en .NET para la Factura Electrónica en Costa Rica

[![GitHub](https://img.shields.io/github/license/CRLibre/fe-hacienda-cr-dotnet.svg)](https://github.com/CRLibre/fe-hacienda-cr-dotnet/blob/master/LICENSE) 
[![GitHub commit activity the past week, 4 weeks, year](https://img.shields.io/github/commit-activity/y/CRLibre/fe-hacienda-cr-dotnet.svg?logo=github)](https://github.com/CRLibre/fe-hacienda-cr-dotnet/commits) 
[![GitHub issues](https://img.shields.io/github/issues-raw/CRLibre/fe-hacienda-cr-dotnet.svg)](https://github.com/CRLibre/fe-hacienda-cr-dotnet/issues) 
[![GitHub issues](https://img.shields.io/github/issues-pr/CRLibre/fe-hacienda-cr-dotnet.svg)](https://github.com/CRLibre/fe-hacienda-cr-dotnet/pulls) [![Telegram @CRLibreFE](https://img.shields.io/badge/Telegram-%40CRLibreFE-blue.svg?logo=telegram)](https://crlibre.org/chats/)

## Sobre CRLibre
Somos una comunidad de individuos y organizaciones que voluntariamente unimos esfuerzos para colaborar y compartir conocimiento, crear software libre para resolver problemas que enfrentamos en nuestra realidad en Costa Rica.

En este repositorio estamos compartiendo código en .NET útiles para proyectos que implementan la Factura Electrónica del Ministerio de Hacienda de Costa Rica.

## Cómo colaborar

* Póngase en contacto con los otros miembros voluntarios de la comunidad.
   * [Sistema de Preguntas y Respuestas de la Comunidad](https://crlibre.org/qa/)
   * [Grupos de CHAT de CRLibre.org](https://crlibre.org/chats/)
   * [Grupo de Facebook CRLibre](https://www.facebook.com/groups/105812240170199/)

## Cómo colaborar
Ver archivo [CONTRIBUTING.md](CONTRIBUTING.md) para más información

## Sobre este Connector
Este conector está en ASP.NET MVC, la idea es realizar una aplicación que pueda interactuar con el 
[API de CRLibre]( https://github.com/CRLibre/API_Hacienda) , por medio de un conector.

En la aplicación se encuentra un archivo en CRLibre/web.config donde encontraremos una variable “ApiServer”  <add key="ApiServer" value="http://localhost:81/api.php" /> , en esta se debe escribir la URL de donde se encuentra el API.

Se creo una clase /CRLibre/Models/ApiConnect.cs que es el conector con el API al lado servidor de nuestra aplicación.

*	En la función PostApi() enviamos 3 parámetros los cuales son:
  *	Dictionary<string, string> values (Los datos que se deseen enviar)
  *	string module (Nombre del módulo del API = “w”)
  *	string action  (Nombre de la acción del módulo = “r” )
## Ejemplo de uso del conector

    //Se importa models en el casos de usar fuera de Models
    using CRLibre.Models;
    //Codigo...
    .......
    bool isAuthenticated = false;
    string sessionKey = "";
    try
    {
        //Se crea un directorio de parámetros
        var values = new Dictionary<string, string>
        {
            { "userName", username },
            { "pwd", password }
        };
        //Se instancia la clase
        ApiConnect api = new ApiConnect();
        //Se llama la la funcion PostApi y se envian los parametros
        JToken jObjet = api.PostApi(values,"users", "users_log_me_in");
        //Se obtiene el objeto deseado
        sessionKey = (string)jObjet["sessionKey"];
        isAuthenticated = true;
    }
    catch (Exception e)
    {
        //Normalmente ocurre error al no encontrar el objeto. se puede hacer un control más adecuado según sea necesario.
        return new AuthenticationResult("El usuario o la contraseña son incorrectos");
    }
