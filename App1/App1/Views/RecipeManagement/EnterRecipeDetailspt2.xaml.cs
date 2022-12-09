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
    public partial class EnterRecipeDetailspt2 : ContentPage
    {
        int counter = 1;

        public EnterRecipeDetailspt2()
        {

            InitializeComponent();
        }
        protected void AddEntry_Clicked(object sender, EventArgs a)
        {
            var btn1 = new Button();

            btn1.BackgroundColor = Color.FromRgb(214, 215, 215);
            btn1.TextColor = Color.FromRgb(0, 0, 0);
            btn1.Text = $"{counter}" + ". " + txt_instruction.Text;
            btn1.FontSize = 18;
            btn1.TextTransform = TextTransform.None;
            btn1.Padding = 5;

            EntryFields.Children.Add(btn1);
            counter++;
            txt_instruction.Text = "";
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnterRecipeDetailspt3());
        }
    }
}