using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores inválidos");
            }

        }

        public double ObterArea()
        {
            if (valido)
            {
                return comprimento * largura;
            }
            else{
                System.Console.WriteLine("Preencha com valores válidos");
                return 0;
            }
        }
    }
}