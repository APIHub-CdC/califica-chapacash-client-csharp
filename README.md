# califica-chapacash-client-csharp

Es un modelo que segmenta a los clientes morosos en 6 calificaciones, de acuerdo al avance esperado de mora en los siguientes 30 días. Reduce costos de gestión y administración de cartera morosa al segmentar a la población.

## Requisitos para Windows

- .NET Core 3.1 SDK [vea como instalar][1]
- MonoDevelop [vea como instalar][2]
- Microsoft .NET Framework 4.8 Developer Pack [vea como instalar][3]

### Requisitos para linux/MacOs
- Se debe contar con las siguientes dependencias para SO linux:
    - nuget
    - mono-devel
    - mono-xbuild

```sh
#ejemplo para instalar las dependencias adicionales
apt install nuget
apt install mono-devel
apt install mono-xbuild
```

## Guía de inicio

### Paso 1. Agregar el producto a la aplicación

Al iniciar sesión seguir os siguientes pasos:

 1. Dar clic en la sección "**Mis aplicaciones**".
 2. Seleccionar la aplicación.
 3. Ir a la pestaña de "**Editar '@tuApp**' ".
    <p align="center">
      <img src="https://github.com/APIHub-CdC/imagenes-cdc/blob/master/edit_applications.jpg" width="900">
    </p>
 4. Al abrirse la ventana emergente, seleccionar el producto.
 5. Dar clic en el botón "**Guardar App**":
    <p align="center">
      <img src="https://github.com/APIHub-CdC/imagenes-cdc/blob/master/selected_product.jpg" width="400">
    </p>

### Paso 2. Capturar los datos de la petición

Los siguientes datos a modificar se encuentran en ***IO.CalificaChapacashCsharp.Test/Api/CalificaApiTests.cs***

Es importante contar con el método Init() que se encargará de inicializar la url. Modificar la URL ***('the_url')*** de la petición de la variable ***basePath***, como se muestra en el siguiente fragmento de código:

```csharp
[SetUp]
public void Init()
{
    string basePath = "your_url";
    this.xApiKey = "your_api_key";
    this.username = "your_username";
    this.password = "your_password";
    this.api = new CalificaApi(basePath);
}

/**
* Este es el método que se será ejecutado en la prueba unitaria, ubicado en path/to/repository/src/IO.CalificaChapacashCsharp.Test/Api/CalificaApiTests.cs 

*/
[Test]
public void ChapacashTest()
{
    DatosConsulta request = new DatosConsulta();
    
    request.NumeroDocumento = "XXXX";
    request.TipoDocumento = 0;
    request.PrimNomRazSoc = "XXX";
    request.SegundoNombre = "XXX";
    request.ApellidoPaterno = "XXX";
    request.ApellidoMaterno = "XXX";
    request.TipoProducto = "XXX";
    request.IngresoBruto = 0;
    request.OtrosIngresos = 0;
    request.ImpuestosGastosVariables = 0;
    request.OtrosDescuentos = 0;
    request.GastosFijos = 0;
    request.DeudasVigentes = 0;
    request.Cuota = (float)0;
    request.Plazo = 0;
    
    var response =this.api.Chapacash( this.xApiKey, this.username, this.password, request );
    Assert.IsInstanceOf<Calificacion> (response, "response is Calificacion");
    Console.WriteLine(response.ToJson());
}
```
## Pruebas unitarias

Para ejecutar las pruebas unitarias con windows:
```sh
# Compilación
build.bat
dotnet msbuild IO.CalificaChapacashCsharp.sln
# Ejecución
"packages/NUnit.Runners.2.6.4/tools/nunit-console.exe" src/IO.CalificaChapacashCsharp.Test/bin/Debug/IO.CalificaChapacashCsharp.Test.dll

```

Para ejecutar las pruebas unitarias con linux:

```sh
# Compilación
sh build.sh
# Ejecución
sh mono_nunit_test.sh
# También puede probar con el siguiente comando
msbuild IO.CalificaChapacashCsharp.sln && \
    mono .bin/IO.EflowPeruSimulCalificaChapacashCsharpacion.Test/bin/Debug/IO.CalificaChapacashCsharp.Test.dll

```
---
[CONDICIONES DE USO, REPRODUCCIÓN Y DISTRIBUCIÓN](https://github.com/APIHub-CdC/licencias-cdc)

[1]: https://dotnet.microsoft.com/download
[2]: https://www.mono-project.com/download/stable/#download-win
[3]: https://www.microsoft.com/es-mx/download/details.aspx?id=30653