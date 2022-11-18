using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaAnimal.Animal
{
    public class Humano : Animal,ClasseTipo
    {
       public Humano(string? nome) : base(nome)
        {
        }

        public void TipoDeClasse()
        {
            Console.WriteLine("Sou mamífero");
        }
        public override void Breathing()
        {
            Console.WriteLine("Possuo pulmões, e eles fazem parte da minha respiração");
        }
        public override void Locomotion()
        {
            Console.WriteLine("Me locomovo de maneira ereta");
        }
        public override void Diet()
        {
            Console.WriteLine("Sou Onívoro");
        }
        public Humano(int idade) : base(idade)
        {
        }
    }
}
