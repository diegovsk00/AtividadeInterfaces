using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Helicoptero : IMaquina, IPairador, IVoador
    {
        void IMaquina.Abastecer()
        {
            Console.WriteLine("Colocando combustivel no helicoptero");
        }

        void IMaquina.Alerta()
        {
            Console.WriteLine("Alerta a helice esta com poblema");
        }

        void IVoador.Cair()
        {
            Console.WriteLine("O helicoptero esta caindo");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("O helicoptero esta se preparando para decolar");
        }

        void IMaquina.Desligar()
        {
            Console.WriteLine("Deslligando helicoptero apos pouso");
        }

        bool IEquatable<IVoador>.Equals(IVoador? other)
        {
            throw new NotImplementedException();
        }

        void IMaquina.Ligar()
        {
            Console.WriteLine("Ligando o helicoptero para a decolagem");
        }

        void IPairador.Pairar()
        {
            Console.WriteLine("O helicoptero esta pairando sobre a cidade");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("O helicoptero esta diminuindo a potencia das helices");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("O helicoptero esta se preparando para pousagem");
        }
    }
}
