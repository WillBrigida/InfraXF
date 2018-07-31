using InfraXF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.ViewModels
{
    public class MainViewModel
    {
        // A classe mais importante de todas

        #region Propriedade

        public LoginViewModel Login { get; set; }
        public HomeViewModel Home { get; set; }

        #endregion

        #region Construtor

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }

        #endregion

        #region MyRegion
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
