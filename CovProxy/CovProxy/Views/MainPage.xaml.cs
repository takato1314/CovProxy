using System;
using System.Collections.Generic;
using System.Linq;
using CovProxy.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CovProxy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetTripLogEntries();
        }

        #region Properties

        public List<TripLogEntry> TripLogEntries { get; set; }

        #endregion

        #region Public

        public void GetTripLogEntries()
        {
            TripLogEntries = new List<TripLogEntry>
            {
                new TripLogEntry
                {
                    Location = new Location
                    {
                        Name = "Washington Monument",
                        Latitude = 38.8895,
                        Longitude = -77.0352
                    },
                    VisitedOn = new DateTime(2019, 2, 5),
                    Notes = "Amazing!"
                },
                new TripLogEntry
                {
                    Location = new Location
                    {
                        Name = "Statue of Liberty",
                        Latitude = 40.6892,
                        Longitude = -74.0444
                    },
                    VisitedOn = new DateTime(2019, 4, 13),
                    Notes = "Inspiring"
                },
                new TripLogEntry
                {
                    Location = new Location
                    {
                        Name = "Golden Gate Bridge",
                        Latitude = 37.8268,
                        Longitude = -122.4798
                    },
                    VisitedOn = new DateTime(2019, 4, 26),
                    Notes = "Foggy, but beautiful"
                }
            };

            LoggingList.ItemsSource = TripLogEntries;
        }

        #endregion

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewEntryPage());
        }

        private async void LoggingList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var trip = (TripLogEntry) e.CurrentSelection.
                FirstOrDefault();
            if (trip != null)
            {
                await Navigation.PushAsync(new TripDetailPage(trip));
            }
            // Clear selection
            LoggingList.SelectedItem = null;
        }
    }
}