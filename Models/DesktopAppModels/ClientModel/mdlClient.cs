using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ClientModel
{
    public class mdlClient
    {
        public String cpf { get; set; }
        public String nome { get; set; }
        public String rua { get; set; }
        public int nr_rua { get; set; }
        public String dt_nasc { get; set; }
        public Double renda { get; set; }
    }
}
