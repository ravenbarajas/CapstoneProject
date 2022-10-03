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
    public partial class DietTypePage : ContentPage
    {
        public DietTypePage()
        {
            InitializeComponent();
        }
        private async void Page7to8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodAllergyPage());
        }
    }
}