using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2aula5
{
    public class Circulo
    {
        public double Area { get; set; }
        public double Raio { get; set; }
        public double Comprimento { get; set; }

        public double CalculaArea(double Raio)
        {
            Area = Math.PI * Math.Pow(Raio, 2);
            return Area;
        }
        public double CalculaComprimento(double Comprimento)
        {
            Comprimento = 2 * Math.PI * Raio;
            return Comprimento;
        }
    }
}
