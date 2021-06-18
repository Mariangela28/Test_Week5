﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek5.Entities
{
    public class Studente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoNascita { get; set; }
        public override string ToString()
        {
            return $"{ID} - {Nome} - {Cognome} - {AnnoNascita}";
        }
    }
}
