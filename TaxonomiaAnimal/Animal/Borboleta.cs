using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaAnimal.Animal
{
    internal class Borboleta : Animal, ClasseTipo
    {
        public Borboleta(string nome) : base(nome)
        {
        }

        public Borboleta(int idade) : base(idade)
        {
        }

        public override void Breathing()
        {
            Console.WriteLine("A minha respiração é feita graças a um sistema de tubos internos chamados traquéia");
        }

        public override void Diet()
        {
            Console.WriteLine("Posso ser Onívora, mas normalmente sou herbívora");
        }

        public override void Locomotion()
        {
            Console.WriteLine("Me locomovo voando");
        }

        public void TipoDeClasse()
        {
            Console.WriteLine("Sou um Inseto");
        }
    }
}
