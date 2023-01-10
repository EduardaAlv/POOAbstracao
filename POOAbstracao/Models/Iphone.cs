using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAbstracao.Models
{
    public class Iphone : Smartphone
    {
        public Iphone() : base("99999999", "Padrao", 8)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando Iphone...");
        }
    }
}
