using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.Models
{
    public class Usuario
    {
        [PrimaryKey]
        public int CodUsuario { get; set; }
        public string NomeUsuario { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Produto> Produtos { get; set; }
        public override int GetHashCode()
        {
            return CodUsuario;
        }
    }
}
