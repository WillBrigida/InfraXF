using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Notificação
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void Notificar([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string prop = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }
            storage = value;
            Notificar(prop);
            return true;
        }
        #endregion

        #region Suporte
        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set {SetProperty(ref isRunning , value); }
        }

        #endregion
    }
}