using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using RCCPMDateConverter = IO.CalificaChapacashCsharp.Client.RCCPMDateConverter;

namespace IO.CalificaChapacashCsharp.Model
{
    [DataContract]
    public partial class DatosConsulta :  IEquatable<DatosConsulta>, IValidatableObject
    {
        [JsonConstructorAttribute]
        protected DatosConsulta() { }
        public DatosConsulta(string numeroDocumento = default(string), int? tipoDocumento = default(int?), string primNomRazSoc = default(string), string segundoNombre = default(string), string apellidoPaterno = default(string), string apellidoMaterno = default(string), string tipoProducto = default(string), int? ingresoBruto = default(int?), int? otrosIngresos = default(int?), int? impuestosGastosVariables = default(int?), int? otrosDescuentos = default(int?), int? gastosFijos = default(int?), int? deudasVigentes = default(int?), float? cuota = default(float?), int? plazo = default(int?))
        {   
            
            this.NumeroDocumento = numeroDocumento;
            this.TipoDocumento = tipoDocumento;
            this.TipoProducto = tipoProducto;
            this.IngresoBruto = ingresoBruto;
            this.ImpuestosGastosVariables = impuestosGastosVariables;
            this.GastosFijos = gastosFijos;
            this.Cuota = cuota;
            this.Plazo = plazo;
            this.PrimNomRazSoc = primNomRazSoc;
            this.SegundoNombre = segundoNombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.OtrosIngresos = otrosIngresos;
            this.OtrosDescuentos = otrosDescuentos;
            this.DeudasVigentes = deudasVigentes;
        }
        [DataMember(Name="tipoProducto", EmitDefaultValue=false)]
        public string TipoProducto { get; set; }

        [DataMember(Name="numeroDocumento", EmitDefaultValue=false)]
        public string NumeroDocumento { get; set; }
        [DataMember(Name="tipoDocumento", EmitDefaultValue=false)]
        public int? TipoDocumento { get; set; }
        [DataMember(Name="primNomRazSoc", EmitDefaultValue=false)]
        public string PrimNomRazSoc { get; set; }
        [DataMember(Name="segundoNombre", EmitDefaultValue=false)]
        public string SegundoNombre { get; set; }
        [DataMember(Name="apellidoPaterno", EmitDefaultValue=false)]
        public string ApellidoPaterno { get; set; }
        [DataMember(Name="apellidoMaterno", EmitDefaultValue=false)]
        public string ApellidoMaterno { get; set; }
        [DataMember(Name="ingresoBruto", EmitDefaultValue=false)]
        public int? IngresoBruto { get; set; }
        [DataMember(Name="otrosIngresos", EmitDefaultValue=false)]
        public int? OtrosIngresos { get; set; }
        [DataMember(Name="impuestosGastosVariables", EmitDefaultValue=false)]
        public int? ImpuestosGastosVariables { get; set; }
        [DataMember(Name="otrosDescuentos", EmitDefaultValue=false)]
        public int? OtrosDescuentos { get; set; }
        [DataMember(Name="gastosFijos", EmitDefaultValue=false)]
        public int? GastosFijos { get; set; }
        [DataMember(Name="deudasVigentes", EmitDefaultValue=false)]
        public int? DeudasVigentes { get; set; }
        [DataMember(Name="cuota", EmitDefaultValue=false)]
        public float? Cuota { get; set; }
        [DataMember(Name="plazo", EmitDefaultValue=false)]
        public int? Plazo { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatosConsulta {\n");
            sb.Append("  NumeroDocumento: ").Append(NumeroDocumento).Append("\n");
            sb.Append("  TipoDocumento: ").Append(TipoDocumento).Append("\n");
            sb.Append("  PrimNomRazSoc: ").Append(PrimNomRazSoc).Append("\n");
            sb.Append("  SegundoNombre: ").Append(SegundoNombre).Append("\n");
            sb.Append("  ApellidoPaterno: ").Append(ApellidoPaterno).Append("\n");
            sb.Append("  ApellidoMaterno: ").Append(ApellidoMaterno).Append("\n");
            sb.Append("  TipoProducto: ").Append(TipoProducto).Append("\n");
            sb.Append("  IngresoBruto: ").Append(IngresoBruto).Append("\n");
            sb.Append("  OtrosIngresos: ").Append(OtrosIngresos).Append("\n");
            sb.Append("  ImpuestosGastosVariables: ").Append(ImpuestosGastosVariables).Append("\n");
            sb.Append("  OtrosDescuentos: ").Append(OtrosDescuentos).Append("\n");
            sb.Append("  GastosFijos: ").Append(GastosFijos).Append("\n");
            sb.Append("  DeudasVigentes: ").Append(DeudasVigentes).Append("\n");
            sb.Append("  Cuota: ").Append(Cuota).Append("\n");
            sb.Append("  Plazo: ").Append(Plazo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DatosConsulta);
        }
        public bool Equals(DatosConsulta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NumeroDocumento == input.NumeroDocumento ||
                    (this.NumeroDocumento != null &&
                    this.NumeroDocumento.Equals(input.NumeroDocumento))
                ) && 
                (
                    this.TipoDocumento == input.TipoDocumento ||
                    (this.TipoDocumento != null &&
                    this.TipoDocumento.Equals(input.TipoDocumento))
                ) && 
                (
                    this.PrimNomRazSoc == input.PrimNomRazSoc ||
                    (this.PrimNomRazSoc != null &&
                    this.PrimNomRazSoc.Equals(input.PrimNomRazSoc))
                ) && 
                (
                    this.SegundoNombre == input.SegundoNombre ||
                    (this.SegundoNombre != null &&
                    this.SegundoNombre.Equals(input.SegundoNombre))
                ) && 
                (
                    this.ApellidoPaterno == input.ApellidoPaterno ||
                    (this.ApellidoPaterno != null &&
                    this.ApellidoPaterno.Equals(input.ApellidoPaterno))
                ) && 
                (
                    this.ApellidoMaterno == input.ApellidoMaterno ||
                    (this.ApellidoMaterno != null &&
                    this.ApellidoMaterno.Equals(input.ApellidoMaterno))
                ) && 
                (
                    this.TipoProducto == input.TipoProducto ||
                    (this.TipoProducto != null &&
                    this.TipoProducto.Equals(input.TipoProducto))
                ) && 
                (
                    this.IngresoBruto == input.IngresoBruto ||
                    (this.IngresoBruto != null &&
                    this.IngresoBruto.Equals(input.IngresoBruto))
                ) && 
                (
                    this.OtrosIngresos == input.OtrosIngresos ||
                    (this.OtrosIngresos != null &&
                    this.OtrosIngresos.Equals(input.OtrosIngresos))
                ) && 
                (
                    this.ImpuestosGastosVariables == input.ImpuestosGastosVariables ||
                    (this.ImpuestosGastosVariables != null &&
                    this.ImpuestosGastosVariables.Equals(input.ImpuestosGastosVariables))
                ) && 
                (
                    this.OtrosDescuentos == input.OtrosDescuentos ||
                    (this.OtrosDescuentos != null &&
                    this.OtrosDescuentos.Equals(input.OtrosDescuentos))
                ) && 
                (
                    this.GastosFijos == input.GastosFijos ||
                    (this.GastosFijos != null &&
                    this.GastosFijos.Equals(input.GastosFijos))
                ) && 
                (
                    this.DeudasVigentes == input.DeudasVigentes ||
                    (this.DeudasVigentes != null &&
                    this.DeudasVigentes.Equals(input.DeudasVigentes))
                ) && 
                (
                    this.Cuota == input.Cuota ||
                    (this.Cuota != null &&
                    this.Cuota.Equals(input.Cuota))
                ) && 
                (
                    this.Plazo == input.Plazo ||
                    (this.Plazo != null &&
                    this.Plazo.Equals(input.Plazo))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NumeroDocumento != null)
                    hashCode = hashCode * 59 + this.NumeroDocumento.GetHashCode();
                if (this.TipoDocumento != null)
                    hashCode = hashCode * 59 + this.TipoDocumento.GetHashCode();
                if (this.PrimNomRazSoc != null)
                    hashCode = hashCode * 59 + this.PrimNomRazSoc.GetHashCode();
                if (this.SegundoNombre != null)
                    hashCode = hashCode * 59 + this.SegundoNombre.GetHashCode();
                if (this.ApellidoPaterno != null)
                    hashCode = hashCode * 59 + this.ApellidoPaterno.GetHashCode();
                if (this.ApellidoMaterno != null)
                    hashCode = hashCode * 59 + this.ApellidoMaterno.GetHashCode();
                if (this.TipoProducto != null)
                    hashCode = hashCode * 59 + this.TipoProducto.GetHashCode();
                if (this.IngresoBruto != null)
                    hashCode = hashCode * 59 + this.IngresoBruto.GetHashCode();
                if (this.OtrosIngresos != null)
                    hashCode = hashCode * 59 + this.OtrosIngresos.GetHashCode();
                if (this.ImpuestosGastosVariables != null)
                    hashCode = hashCode * 59 + this.ImpuestosGastosVariables.GetHashCode();
                if (this.OtrosDescuentos != null)
                    hashCode = hashCode * 59 + this.OtrosDescuentos.GetHashCode();
                if (this.GastosFijos != null)
                    hashCode = hashCode * 59 + this.GastosFijos.GetHashCode();
                if (this.DeudasVigentes != null)
                    hashCode = hashCode * 59 + this.DeudasVigentes.GetHashCode();
                if (this.Cuota != null)
                    hashCode = hashCode * 59 + this.Cuota.GetHashCode();
                if (this.Plazo != null)
                    hashCode = hashCode * 59 + this.Plazo.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
