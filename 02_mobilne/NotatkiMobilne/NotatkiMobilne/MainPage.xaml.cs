using System.Collections.ObjectModel;

namespace NotatkiMobilne
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Notatki { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Notatki = new ObservableCollection<string>
            {
                "Kupić mleko i chleb",
                "Wizyta u weterynarza o 16:00",
                "Przegląd samochodu"
            };

            NotatkiListView.ItemsSource = Notatki;
        }

        private void OnDodajClicked(object sender, EventArgs e)
        {
            string tekstNotatki = NotatkaEntry.Text;
            if (!string.IsNullOrWhiteSpace(tekstNotatki))
            {
                Notatki.Add(tekstNotatki.Trim());

                NotatkaEntry.Text = string.Empty;
            }
        }
    }
}