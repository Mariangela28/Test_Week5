using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek5.Entities
{
    public class Esame
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public int CFU { get; set; }
        public DateTime DataEsame { get; set; }
        public int Votazione { get; set; }
        public String Passato { get; set; }
        public int StudenteID { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Nome} - {CFU} - {DataEsame} - {Votazione} - {Passato} - {StudenteID}";
        }
    }
}
