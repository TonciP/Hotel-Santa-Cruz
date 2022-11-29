using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record DniValue : ValueObject
    {
        public string Value { get; }
        public DniValue(string value)
        {
            if (value.Length > 15) // value lent no mayor a 500
                throw new BussinessRuleValidationException("El Valor del nombre no puede contener mayor a 15 caracteres");
            Value = value;

        }
        public static implicit operator string(DniValue value)
        {
            return value.Value;
        }
        public static implicit operator DniValue(string value)
        {
            return new DniValue(value);
        }
    }
}
