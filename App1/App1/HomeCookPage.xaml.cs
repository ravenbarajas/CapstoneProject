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
    public partial class HomeCookPage : ContentPage
    {
        public HomeCookPage()
        {
            InitializeComponent();
        }
        private async void Page3to4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FrequencyPage());
        }
        private void Selection_Clicked(object sender, EventArgs e)
        {
            Option1.BackgroundColor = Color.FromRgb(217, 217, 217);
            Option1.TextColor = Color.Black;
            Option1.BorderWidth = 1;
            Option1.BorderColor = Color.White;

            Option2.BackgroundColor = Color.FromRgb(217, 217, 217);
            Option2.TextColor = Color.Black;
            Option2.BorderWidth = 1;
            Option2.BorderColor = Color.White;

            Option3.BackgroundColor = Color.FromRgb(217, 217, 217);
            Option3.TextColor = Color.Black;
            Option3.BorderWidth = 1;
            Option3.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
    }
}