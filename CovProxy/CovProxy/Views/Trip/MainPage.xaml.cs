using System;
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
        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewTripEntryPage());
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