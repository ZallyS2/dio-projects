using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacesAbstratas.Interfaces
{
    public interface ICalculadora
    {
        int somar(int x, int y);
        int subtrair(int x, int y);
        int multiplicar(int x, int y);
        int dividir(int x, int y);
    }
}