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
    public partial class Variable :  IEquatable<Variable>, IValidatableObject
    {
        public Variable(string nombre = default(string), string tipo = default(string), Object valor = default(Object))
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Valor = valor;
        }
        [DataMember(Name="nombre", EmitDefaultValue=false)]
        public string Nombre { get; set; }
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public string Tipo { get; set; }
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public Object Valor { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Variable {\n");
            sb.Append("  Nombre: ").Append(Nombre).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Variable);
        }
        public bool Equals(Variable input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Nombre == input.Nombre ||
                    (this.Nombre != null &&
                    this.Nombre.Equals(input.Nombre))
                ) && 
                (
                    this.Tipo == input.Tipo ||
                    (this.Tipo != null &&
                    this.Tipo.Equals(input.Tipo))
                ) && 
                (
                    this.Valor == input.Valor ||
                    (this.Valor != null &&
                    this.Valor.Equals(input.Valor))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Nombre != null)
                    hashCode = hashCode * 59 + this.Nombre.GetHashCode();
                if (this.Tipo != null)
                    hashCode = hashCode * 59 + this.Tipo.GetHashCode();
                if (this.Valor != null)
                    hashCode = hashCode * 59 + this.Valor.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
