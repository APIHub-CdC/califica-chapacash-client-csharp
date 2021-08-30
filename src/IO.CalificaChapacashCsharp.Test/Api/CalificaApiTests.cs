using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;

using NUnit.Framework;using IO.CalificaChapacashCsharp.Client;
using IO.CalificaChapacashCsharp.Api;
using IO.CalificaChapacashCsharp.Model;

namespace IO.CalificaChapacashCsharp.Test
{
    [TestFixture]
    public class CalificaApiTests
    {
        private string xApiKey;
        private string username;
        private string password;
        private CalificaApi api;
        [SetUp]
        public void Init()
        {
            string basePath = "your_url";
            this.xApiKey = "your_api_key";
            this.username = "your_username";
            this.password = "your_password";
            this.api = new CalificaApi(basePath);
        }

        
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
        
    }
}
