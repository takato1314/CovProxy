using CovProxy.Models;

namespace CovProxy.ViewModels.Trip
{
    public class DetailViewModel : BaseViewModel
    {
        public DetailViewModel(TripLogEntry entry)
        {
            Entry = entry;
        }

        TripLogEntry _entry;
        public TripLogEntry Entry
        {
            get => _entry;
            set
            {
                _entry = value;
                OnPropertyChanged();
            }
        }
    }
}
