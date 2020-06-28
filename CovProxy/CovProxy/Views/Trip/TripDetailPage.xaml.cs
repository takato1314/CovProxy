using CovProxy.Models;
using CovProxy.ViewModels.Trip;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace CovProxy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TripDetailPage : ContentPage
    {
        public TripDetailPage(TripLogEntry tripLogEntry)
        {
            BindingContext = new DetailViewModel(tripLogEntry);
            InitializeComponent();

            LoadData();
        }

        #region Properties

        public DetailViewModel DetailViewModel => BindingContext as DetailViewModel;

        #endregion

        #region Public

        public void LoadData()
        {
            Map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(DetailViewModel.Entry.Location.Latitude,
                    DetailViewModel.Entry.Location.Longitude),
                Distance.FromMiles(.5)));
            Map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Label = DetailViewModel.Entry.Location.Name,
                Position = new Position(DetailViewModel.Entry.Location.Latitude,
                    DetailViewModel.Entry.Location.Longitude)
            });
        }

        #endregion
    }
}