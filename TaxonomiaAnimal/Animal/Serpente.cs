using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaAnimal.Animal
{
    internal class Serpente : Animal,ClasseTipo
    {
        public Serpente(string nome) : base(nome)
        {
        }

        public Serpente(int idade) : base(idade)
        {
        }

        public override void Breathing()
        {
            Console.WriteLine("Possuo pulmões, e eles fazem parte da minha respiração");
        }

        public override void Diet()
        {
            Console.WriteLine("Sou Carnívoro");
        }

        public override void Locomotion()
        {
            Console.WriteLine("Me locomovo de maneira serpentina, ou seja, fazendo ciclos de contração musculares em lados opostos da coluna vertebral. Em forta de um 's'.");
        }

        public void TipoDeClasse()
        {
            Console.WriteLine("Sou um Réptil");
        }
    }
}
