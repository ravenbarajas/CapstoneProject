using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoriteDishPage : ContentPage
    {
        public FavoriteDishPage()
        {
            InitializeComponent();
        }
        private async void Page4to5_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new TimePage());
        }
    }
}