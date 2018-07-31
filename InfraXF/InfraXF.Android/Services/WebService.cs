using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using InfraXF.Models;
using InfraXF.Services;
using Xamarin.Forms;

[assembly : Dependency(typeof(InfraXF.Droid.Services.WebService))]
namespace InfraXF.Droid.Services
{
    public class WebService : IWebService
    {
        public List<Produto> ListaProdutos()
        {
            var list = new List<Produto>()
            {
                new Produto() {CodProduto = 1, NomeProduto = "Prod1", Usuario = new Usuario {CodUsuario = 01, NomeUsuario = "Tet",
                } }
            };
            return list;
        }
    }
}