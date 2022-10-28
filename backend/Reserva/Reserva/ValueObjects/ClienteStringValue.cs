using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record ClienteStringValue : ValueObject
    {
        public string Value { get; }
        public ClienteStringValue(string value)
        {
            if (value.Length > 500) // value lent no mayor a 500
                throw new BussinessRuleValidationException("El Valor del nombre no puede contener mayor a 500 caracteres");
            Value = value;

        }
        public static implicit operator string(ClienteStringValue value)
        {
            return value.Value;
        }
        public static implicit operator ClienteStringValue(string value)
        {
            return new ClienteStringValue(value);
        }
    }
}
