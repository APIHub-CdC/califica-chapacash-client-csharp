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
    public partial class Calificacion :  IEquatable<Calificacion>, IValidatableObject
    {
        public Calificacion(int? numeroConsulta = default(int?), string claveRecomendacion = default(string), string recomendacion = default(string), string tipoProducto = default(string), string nombreProducto = default(string), decimal? montoLineaCredito = default(decimal?), int? flagLineaCreditoAlta = default(int?), string msgLineaCreditoAlta = default(string), string mensaje = default(string), List<Object> motivos = default(List<Object>), List<Variable> variables = default(List<Variable>))
        {
            this.NumeroConsulta = numeroConsulta;
            this.ClaveRecomendacion = claveRecomendacion;
            this.Recomendacion = recomendacion;
            this.TipoProducto = tipoProducto;
            this.NombreProducto = nombreProducto;
            this.MontoLineaCredito = montoLineaCredito;
            this.FlagLineaCreditoAlta = flagLineaCreditoAlta;
            this.MsgLineaCreditoAlta = msgLineaCreditoAlta;
            this.Mensaje = mensaje;
            this.Motivos = motivos;
            this.Variables = variables;
        }
        [DataMember(Name="numeroConsulta", EmitDefaultValue=false)]
        public int? NumeroConsulta { get; set; }
        [DataMember(Name="claveRecomendacion", EmitDefaultValue=false)]
        public string ClaveRecomendacion { get; set; }
        [DataMember(Name="recomendacion", EmitDefaultValue=false)]
        public string Recomendacion { get; set; }
        [DataMember(Name="tipoProducto", EmitDefaultValue=false)]
        public string TipoProducto { get; set; }
        [DataMember(Name="nombreProducto", EmitDefaultValue=false)]
        public string NombreProducto { get; set; }
        [DataMember(Name="montoLineaCredito", EmitDefaultValue=false)]
        public decimal? MontoLineaCredito { get; set; }
        [DataMember(Name="flagLineaCreditoAlta", EmitDefaultValue=false)]
        public int? FlagLineaCreditoAlta { get; set; }
        [DataMember(Name="msgLineaCreditoAlta", EmitDefaultValue=false)]
        public string MsgLineaCreditoAlta { get; set; }
        [DataMember(Name="mensaje", EmitDefaultValue=false)]
        public string Mensaje { get; set; }
        [DataMember(Name="motivos", EmitDefaultValue=false)]
        public List<Object> Motivos { get; set; }
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<Variable> Variables { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Calificacion {\n");
            sb.Append("  NumeroConsulta: ").Append(NumeroConsulta).Append("\n");
            sb.Append("  ClaveRecomendacion: ").Append(ClaveRecomendacion).Append("\n");
            sb.Append("  Recomendacion: ").Append(Recomendacion).Append("\n");
            sb.Append("  TipoProducto: ").Append(TipoProducto).Append("\n");
            sb.Append("  NombreProducto: ").Append(NombreProducto).Append("\n");
            sb.Append("  MontoLineaCredito: ").Append(MontoLineaCredito).Append("\n");
            sb.Append("  FlagLineaCreditoAlta: ").Append(FlagLineaCreditoAlta).Append("\n");
            sb.Append("  MsgLineaCreditoAlta: ").Append(MsgLineaCreditoAlta).Append("\n");
            sb.Append("  Mensaje: ").Append(Mensaje).Append("\n");
            sb.Append("  Motivos: ").Append(Motivos).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Calificacion);
        }
        public bool Equals(Calificacion input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NumeroConsulta == input.NumeroConsulta ||
                    (this.NumeroConsulta != null &&
                    this.NumeroConsulta.Equals(input.NumeroConsulta))
                ) && 
                (
                    this.ClaveRecomendacion == input.ClaveRecomendacion ||
                    (this.ClaveRecomendacion != null &&
                    this.ClaveRecomendacion.Equals(input.ClaveRecomendacion))
                ) && 
                (
                    this.Recomendacion == input.Recomendacion ||
                    (this.Recomendacion != null &&
                    this.Recomendacion.Equals(input.Recomendacion))
                ) && 
                (
                    this.TipoProducto == input.TipoProducto ||
                    (this.TipoProducto != null &&
                    this.TipoProducto.Equals(input.TipoProducto))
                ) && 
                (
                    this.NombreProducto == input.NombreProducto ||
                    (this.NombreProducto != null &&
                    this.NombreProducto.Equals(input.NombreProducto))
                ) && 
                (
                    this.MontoLineaCredito == input.MontoLineaCredito ||
                    (this.MontoLineaCredito != null &&
                    this.MontoLineaCredito.Equals(input.MontoLineaCredito))
                ) && 
                (
                    this.FlagLineaCreditoAlta == input.FlagLineaCreditoAlta ||
                    (this.FlagLineaCreditoAlta != null &&
                    this.FlagLineaCreditoAlta.Equals(input.FlagLineaCreditoAlta))
                ) && 
                (
                    this.MsgLineaCreditoAlta == input.MsgLineaCreditoAlta ||
                    (this.MsgLineaCreditoAlta != null &&
                    this.MsgLineaCreditoAlta.Equals(input.MsgLineaCreditoAlta))
                ) && 
                (
                    this.Mensaje == input.Mensaje ||
                    (this.Mensaje != null &&
                    this.Mensaje.Equals(input.Mensaje))
                ) && 
                (
                    this.Motivos == input.Motivos ||
                    this.Motivos != null &&
                    this.Motivos.SequenceEqual(input.Motivos)
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NumeroConsulta != null)
                    hashCode = hashCode * 59 + this.NumeroConsulta.GetHashCode();
                if (this.ClaveRecomendacion != null)
                    hashCode = hashCode * 59 + this.ClaveRecomendacion.GetHashCode();
                if (this.Recomendacion != null)
                    hashCode = hashCode * 59 + this.Recomendacion.GetHashCode();
                if (this.TipoProducto != null)
                    hashCode = hashCode * 59 + this.TipoProducto.GetHashCode();
                if (this.NombreProducto != null)
                    hashCode = hashCode * 59 + this.NombreProducto.GetHashCode();
                if (this.MontoLineaCredito != null)
                    hashCode = hashCode * 59 + this.MontoLineaCredito.GetHashCode();
                if (this.FlagLineaCreditoAlta != null)
                    hashCode = hashCode * 59 + this.FlagLineaCreditoAlta.GetHashCode();
                if (this.MsgLineaCreditoAlta != null)
                    hashCode = hashCode * 59 + this.MsgLineaCreditoAlta.GetHashCode();
                if (this.Mensaje != null)
                    hashCode = hashCode * 59 + this.Mensaje.GetHashCode();
                if (this.Motivos != null)
                    hashCode = hashCode * 59 + this.Motivos.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
