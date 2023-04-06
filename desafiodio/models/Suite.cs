using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafiodio.models
{
    public class Suite
    {
        public string tipoSuite { get; set; }
        public int capacidade { get; set; }
        public decimal valorDiaria { get; set; }
        
        public Suite(string tipoSuite,int capacidade,decimal valorDiaria){
            this.tipoSuite=tipoSuite;
            this.capacidade=capacidade;
            this.valorDiaria=valorDiaria;
        }
    }
}