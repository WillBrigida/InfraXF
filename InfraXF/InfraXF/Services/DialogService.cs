using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.Services
{
    public class DialogService
    {
        public async Task ShowMessage(string titulo, string mensagem)
        {
            await App.Current.MainPage.DisplayAlert (titulo, mensagem, "Ok");
        }
        
    }
}
