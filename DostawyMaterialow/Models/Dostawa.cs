using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DostawyMaterialow.Models
{
    public class Dostawa
    {
        public int Id { get; set; }
        public string Gatunek { get; set; }
        public string Wytop { get; set; }
        public int Srednica { get; set; }
        public int Dlugosc { get; set; }
        public int Masa { get; set; }
        public string DataDostawy { get; set; }
        public string Dostawca { get; set; }
    }
}
