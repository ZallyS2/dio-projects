using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfacesAbstratas.Interfaces;


namespace InterfacesAbstratas.Models
{
    public class Calculadora : ICalculadora
    {
        public int somar(int x, int y)
        {
            return x + y;
        }

        public int somar(int x, int y, int z)
        {
            return x + y + z;
        }

        public int subtrair(int x, int y)
        {
            return x - y;
        }

        public int multiplicar(int x, int y)
        {
            return x * y;
        }

        public int dividir(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            return x / y;
        }
    }
}