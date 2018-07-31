using InfraXF.Models;
using InfraXF.Services;
using InfraXF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace InfraXF.ViewModels
{
    public class LoginViewModel
    {
        #region Propriedades
        private DialogService dialogService;
        private DataService dataService;
        public ObservableCollection<Produto> Produtos { get; set; }

        #endregion

        #region Contrutor
        public LoginViewModel()
        {
            dialogService = new DialogService();
            dataService = new DataService();
            Produtos = new ObservableCollection<Produto>();
        }
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new Command(OnLoginExecute); } }

        #endregion

        #region Métodos
        private async void OnLoginExecute(object obj)
        {
            await dialogService.ShowMessage("Alerta", "Teste");
            MainViewModel.GetInstance().Home = new HomeViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new HomePage());

            //dataService.InserirUsuario();
        }

        public List<Produto> GetProdutos()
        {
            var produtos = DependencyService.Get<IWebService>().ListaProdutos();
            foreach (var item in produtos)
            {
                //Produtos.Add(new LoginViewModel
                //{
                //};
                //    )
            }
            return produtos;
        }
        #endregion
    }
}
            
               