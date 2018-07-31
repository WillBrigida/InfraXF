using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.Models
{
    public class Resposta
    {
        public string Mensagem { get; set; }
        public bool IsSuccess { get; set; }
        public Object Resultado { get; set; }
    }
}
