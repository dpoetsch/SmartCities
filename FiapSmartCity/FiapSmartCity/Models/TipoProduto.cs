using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiapSmartCity.Models
{
    public class TipoProduto
    {
        public int IdTipo { get; set; }
        public String DescricaoTipo { get; set; }
        public bool Comercializado { get; set; }
    }
}