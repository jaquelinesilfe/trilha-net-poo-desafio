using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_abstraindo_celular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }

        public override void InstalarAplicativo(string nome){
            Console.WriteLine($"Instalando a aplicação {nome} no Iphone.");
        }
    }
}