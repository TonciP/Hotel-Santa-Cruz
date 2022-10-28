using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record TelefonoValue
    {
        public string Value { get; }
        public TelefonoValue(string value)
        {
            if (value.Length != 8) // value lent no mayor a 500
                throw new BussinessRuleValidationException("Telefono no valido");
            Value = value;

        }
        public static implicit operator string(TelefonoValue value)
        {
            return value.Value;
        }
        public static implicit operator TelefonoValue(string value)
        {
            return new TelefonoValue(value);
        }
    }
}
