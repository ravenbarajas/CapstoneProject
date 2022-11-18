using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterRecipeDetailspt1 : ContentPage
    {
        public EnterRecipeDetailspt1()
        {
            InitializeComponent();
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnterRecipeDetailspt2());
        }
    }
}