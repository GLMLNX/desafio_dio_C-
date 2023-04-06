using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafiodio.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservado { get; set; }
        
        public Reserva(List<Pessoa> hospedes,Suite suite,int DiasReservado){
            this.Hospedes=hospedes;
            this.Suite=suite;
            this.DiasReservado=DiasReservado;
        }

        public void cadastrarHospedes(List<Pessoa> hospedes){
            if(hospedes.Count > Suite.capacidade){
                Console.WriteLine("Capacidade acima da suite");
            }else{
                Console.WriteLine("Capacidade Suportada");
                this.Hospedes=hospedes;
            }

        }
        public int obterQuantHospedes(){
            return Hospedes.Count;
        }
        public void cadastrarSuite(Suite suite){
            this.Suite=suite;
        }

        public decimal CalcularValor(){
            decimal valor=Suite.valorDiaria*DiasReservado;
            if(DiasReservado<10){
                return valor;  
            }else{
                return valor-(valor*0.10M);
            }
            

        }
        
        
        
        
    }
}