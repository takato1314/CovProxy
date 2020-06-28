using System;
using CovProxy.Models;
using Xamarin.Forms;

namespace CovProxy.ViewModels
{
    public class NewTripEntryViewModel : BaseViewModel
    {
        public NewTripEntryViewModel()
        {
            VisitedOn = DateTime.Now;
        }

        #region Properties

        string _location;
        public string Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged();
                SaveCommand.ChangeCanExecute();
            }
        }

        double _latitude;
        public double Latitude
        {
            get => _latitude;
            set
            {
                _latitude = value;
                OnPropertyChanged();
            }
        }

        double _longitude;
        public double Longitude
        {
            get => _longitude;
            set
            {
                _longitude = value;
                OnPropertyChanged();
            }
        }

        DateTime _visitedOn;
        public DateTime VisitedOn
        {
            get => _visitedOn;
            set
            {
                _visitedOn = value;
                OnPropertyChanged();
            }
        }

        string _notes;
        public string Notes
        {
            get => _notes;
            set
            {
                _notes = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        private Command _saveCommand;
        public Command SaveCommand =>
            _saveCommand ?? (_saveCommand = new Command(Save,
                CanSave));
        void Save()
        {
            var newItem = new TripLogEntry
            {
                Location = new Location
                {
                    Name = Location,
                    Latitude = Latitude,
                    Longitude = Longitude
                },
                VisitedOn = VisitedOn,
                Notes = Notes
            };
            // TODO: Persist entry in a later chapter
        }
        bool CanSave() => !string.IsNullOrWhiteSpace(Location);

        #endregion
    }
}
