using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventtos.API.Models
{
    public class Eventto
    {
        public int EventtoID { get; set; } 
        public string Local { get; set; }
        public string DataEventto { get; set; }
        public string Tema { get; set; }
        public int QtdePessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }
    }
}