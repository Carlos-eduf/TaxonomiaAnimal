using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaAnimal.Animal
{
    internal class Tubarão : Animal, ClasseTipo
    {
        public Tubarão(string nome) : base(nome)
        {
        }

        public Tubarão(int idade) : base(idade)
        {
        }

        public override void Breathing()
        {
            Console.WriteLine("Minha respiração é realizada graças as Brânquias");
        }

        public override void Diet()
        {
            Console.WriteLine("Sou carnívoro");
        }

        public override void Locomotion()
        {
            Console.WriteLine("Me locomovo nadando");
        }

        public void TipoDeClasse()
        {
            Console.WriteLine("Sou um peixe cartilaginoso");
        }
    }
}
