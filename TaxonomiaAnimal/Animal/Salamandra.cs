using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaAnimal.Animal
{
    internal class Salamandra : Animal, ClasseTipo
    {
        public Salamandra(string nome) : base(nome)
        {
        }

        public Salamandra(int idade) : base(idade)
        {
        }

        public override void Breathing()
        {
            Console.WriteLine("Faço uma repiração Cutânea");
        }

        public override void Diet()
        {
            Console.WriteLine("Sou carnívoro");
        }

        public override void Locomotion()
        {
            Console.WriteLine("Me locomovo por meio de ondulações laterais do corpo e da minha cauda combinadass com o movimento das minhas patas");
        }

        public void TipoDeClasse()
        {
            Console.WriteLine("Sou um Anfíbio");
        }
    }
}
