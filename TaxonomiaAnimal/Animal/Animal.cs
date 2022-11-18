using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxonomiaAnimal.Animal
{
    public abstract class Animal
    {
        public abstract void Breathing();

        public abstract void Locomotion();

        public abstract void Diet();
       
        public Animal(string? nome)
        {
            this.Nome = nome;
        }

        public string? Nome { get; set; }
        public int Idade { get; set; }
        public Animal(int idade)
        {
            this.Idade = idade;
        }

    }
}
