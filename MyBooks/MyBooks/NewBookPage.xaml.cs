using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
using ZXing.Net.Mobile;


namespace MyBooks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewBookPage : ContentPage
    {
        public NewBookPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Success", "We have handled the click EVnet", "Cancel");
            goToScan();


        }


        private async void goToScan()
        {
            var scanPage = new ZXingScannerPage();
            // Navigate to our scanner page

            scanPage.OnScanResult += (result) => {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                    
                });
            };



            await Navigation.PushAsync(scanPage);

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            Games game = new Games()
            {
                Name = nameEntry.Text,
                Publisher = publisherEntry.Text
                //Named=nameentr
            };
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App._dbPath))
            {
                conn.CreateTable<Games>();
                var numberofRows = conn.Insert(game);

                if (numberofRows > 0)
                    DisplayAlert("Success", "Game succesfully inserted", "Great");
                else
                    DisplayAlert("Failure", "Game failed to be inserted", "Dang it!");
            }
        }

    }
}
