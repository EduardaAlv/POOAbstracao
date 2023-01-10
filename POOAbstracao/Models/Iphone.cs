using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOAbstracao.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int memoria) : base(numero, modelo, memoria)
        {
            Numero = numero;
            Modelo = modelo;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando Iphone...");
        }
    }
}
