using InfraXF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.Infraestructure
{
    public class InstanceLocator
    {
        #region Propriedade
        public MainViewModel Main { get; set; }
        #endregion

        #region Construtor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
