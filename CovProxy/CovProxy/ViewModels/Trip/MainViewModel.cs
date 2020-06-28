using System;
using System.Collections.ObjectModel;
using CovProxy.Models;

namespace CovProxy.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            GetTripLogEntries();
        }

        #region Properties

        ObservableCollection<TripLogEntry> _logEntries;
        public ObservableCollection<TripLogEntry> LogEntries
        {
            get => _logEntries;
            set
            {
                _logEntries = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public void GetTripLogEntries()
        {
            LogEntries = new ObservableCollection<TripLogEntry>
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
        }
    }
}
