using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aprendizado.models
{
    public class pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void apresentar()
        {
            Console.WriteLine ($"ola meu nome é {Nome}, e tenho {Idade} anos ");
        }
    }
}