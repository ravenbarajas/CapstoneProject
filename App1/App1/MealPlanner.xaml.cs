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
    public partial class MealPlanner : ContentPage
    {
        public MealPlanner()
        {
            InitializeComponent();
        }
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipePage1());
        }
    }
}