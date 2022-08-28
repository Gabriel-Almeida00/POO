using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public  class Professor : Pessoa
    {
        public int Salario { get; set; }

        public  override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e meu salario é {Salario} ");
        }
    }
}