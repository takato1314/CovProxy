using CovProxy.Models;
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
            InitializeComponent();
            TripLogEntry = tripLogEntry;

            LoadData();
        }

        #region Properties

        public TripLogEntry TripLogEntry { get; set; }

        #endregion

        #region Public

        public void LoadData()
        {
            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(TripLogEntry.Location.Latitude,
                    TripLogEntry.Location.Longitude),
                Distance.FromMiles(.5)));
            map.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Label = TripLogEntry.Location.Name,
                Position = new Position(TripLogEntry.Location.Latitude, TripLogEntry.Location.Longitude)
            });

            location.Text = TripLogEntry.Location.Name;
            visitedOn.Text = TripLogEntry.VisitedOn.ToString("M");
            notes.Text = TripLogEntry.Notes;
        }

        #endregion
    }
}