namespace CovProxy.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            Xamarin.FormsMaps.Init("wcUUshTxqkQEwKmgubhQ~tVfbci03PLX0wCbzinbnHg~AvTmaKgTUD_IBRyNe02CQ58S6U0KaMKyTYv0q6fbzzFKy2VMGDqbjaC-XOncuU1b");

            LoadApplication(new CovProxy.App());
        }
    }
}
