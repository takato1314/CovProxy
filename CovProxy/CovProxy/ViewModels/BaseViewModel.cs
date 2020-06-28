using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CovProxy.ViewModels
{
    public class BaseViewModel
    {
        public BaseViewModel()
        {
        }

        #region Properties

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected virtual void OnPropertyChanged([CallerMemberName]
            string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs
                (propertyName));
        }
    }
}
