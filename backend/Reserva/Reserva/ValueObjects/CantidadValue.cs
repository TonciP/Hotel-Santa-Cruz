using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.ValueObjects
{
    public record class CantidadValue
    {
        public int Value { get; }
        public CantidadValue(int value)
        {
            if (value < 0) // value lent no mayor a 500
                throw new BussinessRuleValidationException("La cantidad no puede ser negativo");
            Value = value;

        }
        public static implicit operator int(CantidadValue value)
        {
            return value.Value;
        }
        public static implicit operator CantidadValue(int value)
        {
            return new CantidadValue(value);
        }
    }
}
