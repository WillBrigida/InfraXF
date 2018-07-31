using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.Models
{
    public class Produto
    {
        [PrimaryKey]

        public int CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal ValorProduto { get; set; }
        [ManyToOne]
        public Usuario Usuario { get; set; }

        public override int GetHashCode()
        {
            return CodProduto;
        }
    }
}
