using ShareKernel.Core;
using System.Text.RegularExpressions;
using System.Globalization;

using System.Linq.Expressions;

namespace ShareKernel.ValueObjects
{
    public record EmailValue : ValueObject
    {
        public string Value { get; }
        public EmailValue(string value)
        {
            string expresion = "«\\w+([-+.’]\\w+)*@\\w+([-.]\\w +)*\\.\\w+([-.]\\w+)*»";
            if (value.Length > 0) // value lent no mayor a 500
                throw new BussinessRuleValidationException("El Valor del email es vacio");
            if(Regex.IsMatch(value, expresion))
            Value = value;

        }
        public static implicit operator string(EmailValue value)
        {
            return value.Value;
        }
        public static implicit operator EmailValue(string value)
        {
            return new EmailValue(value);
        }
    }
}
