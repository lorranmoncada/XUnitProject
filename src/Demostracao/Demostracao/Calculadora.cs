using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demostracao
{
    public class Calculadora
    {
        public double Somar(double v1, double v2) => v1 + v2;

        public double Dividir(double v1, double v2)
        {
            if (v1 == 0 || v2 == 0) throw new DividirByZeroException("Não é possível dividir valor por zero!");
            return v1 / v2;
        }
    }

    public class DividirByZeroException : Exception
    {
        public DividirByZeroException(string message) : base(message) { }

        public DividirByZeroException(string message, Exception innerException)
            : base(message, innerException) { }

    }
}
