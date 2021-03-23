using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
        }
    }

    public interface Motorizado
    {
        void Ligar();
        string NomeMotor { get; set; }
    }

    public class Carro :IMotorizado
    {

    }

}
