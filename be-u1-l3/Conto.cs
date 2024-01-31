using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_u1_l3
{
    public class Conto
    {
        public string Intestatario { get; set; }
   
        public int Totale { get; set; } 

        public Conto(string nome, int totale) { 
        this.Intestatario = nome;
            this.Totale = totale;
        }

        public void Deposito(int dep) {
            this.Totale += dep;
        }
        public void Prelievo(int pre)
        {
            this.Totale -= pre;
        }
    }

    
}
