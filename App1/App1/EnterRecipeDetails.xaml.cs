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
    public partial class EnterRecipeDetails : ContentPage
    {
        public EnterRecipeDetails()
        {
            InitializeComponent();
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnterRecipeDetailsPt2());
        }
    }
}