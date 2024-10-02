using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SuperMan : IVoador, IPairador, ISerVivo
    {
        void IVoador.Cair()
        {
            Console.WriteLine("Jogaram kriptonita e ele caiu");
        }

        void ISerVivo.Comer()
        {
            Console.WriteLine("Superman almoçando com sua mãe");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("Ele olha pro céu, respira fundo e sai do chão com uma vrlocidade imensa");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("Após um dia combatendo vilões, ele foi dormir cansado");
        }

        bool IEquatable<IVoador>.Equals(IVoador? other)
        {
            throw new NotImplementedException();
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("Superman morre?");
        }

        void IPairador.Pairar()
        {
            Console.WriteLine("Superman observando a cidade lá do alto");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("Ele cansa de voar rápido e voa mais tranquilamente");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("Superman vem do céu numa grande velocidade e quebra o chão");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine("O cara precisa respirar pra viver ");
        }
    }
}
