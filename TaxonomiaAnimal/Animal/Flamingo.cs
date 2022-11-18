using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaAnimal.Animal
{
    internal class Flamingo : Animal, ClasseTipo
    {
        public Flamingo(string nome) : base(nome)
        {
        }

        public Flamingo(int idade) : base(idade)
        {
        }

        public override void Breathing()
        {
            Console.WriteLine("Possuo pulmões, e eles fazem parte da minha respiração");
        }

        public override void Diet()
        {
            Console.WriteLine("Sou Onívoro");
        }

        public override void Locomotion()
        {
            Console.WriteLine("Posso me locomover no solo ou no ar");
        }

        public void TipoDeClasse()
        {
            Console.WriteLine("Sou uma Ave");
        }
    }
}
