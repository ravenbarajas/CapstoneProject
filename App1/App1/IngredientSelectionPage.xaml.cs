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
    public partial class IngredientSelectionPage : ContentPage
    {
        public IngredientSelectionPage()
        {
            InitializeComponent();
        }
        private void highlightVGBTN()
        {
            VG00.BackgroundColor = Color.White;
            VG00.TextColor = Color.Black;
            VG00.BorderWidth = 2;
            VG00.BorderColor = Color.FromRgb(30, 64, 114);

            VG01.BackgroundColor = Color.White;
            VG01.TextColor = Color.Black;
            VG01.BorderWidth = 2;
            VG01.BorderColor = Color.FromRgb(30, 64, 114);

            VG02.BackgroundColor = Color.White;
            VG02.TextColor = Color.Black;
            VG02.BorderWidth = 2;
            VG02.BorderColor = Color.FromRgb(30, 64, 114);

            VG10.BackgroundColor = Color.White;
            VG10.TextColor = Color.Black;
            VG10.BorderWidth = 2;
            VG10.BorderColor = Color.FromRgb(30, 64, 114);

            VG11.BackgroundColor = Color.White;
            VG11.TextColor = Color.Black;
            VG11.BorderWidth = 2;
            VG11.BorderColor = Color.FromRgb(30, 64, 114);

            VG12.BackgroundColor = Color.White;
            VG12.TextColor = Color.Black;
            VG12.BorderWidth = 2;
            VG12.BorderColor = Color.FromRgb(30, 64, 114);

            VG20.BackgroundColor = Color.White;
            VG20.TextColor = Color.Black;
            VG20.BorderWidth = 2;
            VG20.BorderColor = Color.FromRgb(30, 64, 114);

            VG21.BackgroundColor = Color.White;
            VG21.TextColor = Color.Black;
            VG21.BorderWidth = 2;
            VG21.BorderColor = Color.FromRgb(30, 64, 114);

            VG22.BackgroundColor = Color.White;
            VG22.TextColor = Color.Black;
            VG22.BorderWidth = 2;
            VG22.BorderColor = Color.FromRgb(30, 64, 114);

            VG30.BackgroundColor = Color.White;
            VG30.TextColor = Color.Black;
            VG30.BorderWidth = 2;
            VG30.BorderColor = Color.FromRgb(30, 64, 114);

            VG31.BackgroundColor = Color.White;
            VG31.TextColor = Color.Black;
            VG31.BorderWidth = 2;
            VG31.BorderColor = Color.FromRgb(30, 64, 114);

            VG32.BackgroundColor = Color.White;
            VG32.TextColor = Color.Black;
            VG32.BorderWidth = 2;
            VG32.BorderColor = Color.FromRgb(30, 64, 114);

            VG40.BackgroundColor = Color.White;
            VG40.TextColor = Color.Black;
            VG40.BorderWidth = 2;
            VG40.BorderColor = Color.FromRgb(30, 64, 114);

            VG41.BackgroundColor = Color.White;
            VG41.TextColor = Color.Black;
            VG41.BorderWidth = 2;
            VG41.BorderColor = Color.FromRgb(30, 64, 114);

            VG42.BackgroundColor = Color.White;
            VG42.TextColor = Color.Black;
            VG42.BorderWidth = 2;
            VG42.BorderColor = Color.FromRgb(30, 64, 114);

            VG50.BackgroundColor = Color.White;
            VG50.TextColor = Color.Black;
            VG50.BorderWidth = 2;
            VG50.BorderColor = Color.FromRgb(30, 64, 114);

            VG51.BackgroundColor = Color.White;
            VG51.TextColor = Color.Black;
            VG51.BorderWidth = 2;
            VG51.BorderColor = Color.FromRgb(30, 64, 114);

            VG52.BackgroundColor = Color.White;
            VG52.TextColor = Color.Black;
            VG52.BorderWidth = 2;
            VG52.BorderColor = Color.FromRgb(30, 64, 114);

            VG60.BackgroundColor = Color.White;
            VG60.TextColor = Color.Black;
            VG60.BorderWidth = 2;
            VG60.BorderColor = Color.FromRgb(30, 64, 114);

            VG61.BackgroundColor = Color.White;
            VG61.TextColor = Color.Black;
            VG61.BorderWidth = 2;
            VG61.BorderColor = Color.FromRgb(30, 64, 114);

            VG62.BackgroundColor = Color.White;
            VG62.TextColor = Color.Black;
            VG62.BorderWidth = 2;
            VG62.BorderColor = Color.FromRgb(30, 64, 114);

            VG70.BackgroundColor = Color.White;
            VG70.TextColor = Color.Black;
            VG70.BorderWidth = 2;
            VG70.BorderColor = Color.FromRgb(30, 64, 114);

            VG71.BackgroundColor = Color.White;
            VG71.TextColor = Color.Black;
            VG71.BorderWidth = 2;
            VG71.BorderColor = Color.FromRgb(30, 64, 114);

            VG72.BackgroundColor = Color.White;
            VG72.TextColor = Color.Black;
            VG72.BorderWidth = 2;
            VG72.BorderColor = Color.FromRgb(30, 64, 114);

            VG80.BackgroundColor = Color.White;
            VG80.TextColor = Color.Black;
            VG80.BorderWidth = 2;
            VG80.BorderColor = Color.FromRgb(30, 64, 114);

            VG81.BackgroundColor = Color.White;
            VG81.TextColor = Color.Black;
            VG81.BorderWidth = 2;
            VG81.BorderColor = Color.FromRgb(30, 64, 114);

            VG82.BackgroundColor = Color.White;
            VG82.TextColor = Color.Black;
            VG82.BorderWidth = 2;
            VG82.BorderColor = Color.FromRgb(30, 64, 114);

            VG90.BackgroundColor = Color.White;
            VG90.TextColor = Color.Black;
            VG90.BorderWidth = 2;
            VG90.BorderColor = Color.FromRgb(30, 64, 114);

            VG91.BackgroundColor = Color.White;
            VG91.TextColor = Color.Black;
            VG91.BorderWidth = 2;
            VG91.BorderColor = Color.FromRgb(30, 64, 114);

            VG92.BackgroundColor = Color.White;
            VG92.TextColor = Color.Black;
            VG92.BorderWidth = 2;
            VG92.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightFRBTN()
        {
            FR00.BackgroundColor = Color.White;
            FR00.TextColor = Color.Black;
            FR00.BorderWidth = 2;
            FR00.BorderColor = Color.FromRgb(30, 64, 114);

            FR01.BackgroundColor = Color.White;
            FR01.TextColor = Color.Black;
            FR01.BorderWidth = 2;
            FR01.BorderColor = Color.FromRgb(30, 64, 114);

            FR02.BackgroundColor = Color.White;
            FR02.TextColor = Color.Black;
            FR02.BorderWidth = 2;
            FR02.BorderColor = Color.FromRgb(30, 64, 114);

            FR10.BackgroundColor = Color.White;
            FR10.TextColor = Color.Black;
            FR10.BorderWidth = 2;
            FR10.BorderColor = Color.FromRgb(30, 64, 114);

            FR11.BackgroundColor = Color.White;
            FR11.TextColor = Color.Black;
            FR11.BorderWidth = 2;
            FR11.BorderColor = Color.FromRgb(30, 64, 114);

            FR12.BackgroundColor = Color.White;
            FR12.TextColor = Color.Black;
            FR12.BorderWidth = 2;
            FR12.BorderColor = Color.FromRgb(30, 64, 114);

            FR20.BackgroundColor = Color.White;
            FR20.TextColor = Color.Black;
            FR20.BorderWidth = 2;
            FR20.BorderColor = Color.FromRgb(30, 64, 114);

            FR21.BackgroundColor = Color.White;
            FR21.TextColor = Color.Black;
            FR21.BorderWidth = 2;
            FR21.BorderColor = Color.FromRgb(30, 64, 114);

            FR22.BackgroundColor = Color.White;
            FR22.TextColor = Color.Black;
            FR22.BorderWidth = 2;
            FR22.BorderColor = Color.FromRgb(30, 64, 114);

            VG30.BackgroundColor = Color.White;
            VG30.TextColor = Color.Black;
            VG30.BorderWidth = 2;
            VG30.BorderColor = Color.FromRgb(30, 64, 114);

            VG31.BackgroundColor = Color.White;
            VG31.TextColor = Color.Black;
            VG31.BorderWidth = 2;
            VG31.BorderColor = Color.FromRgb(30, 64, 114);

            VG32.BackgroundColor = Color.White;
            VG32.TextColor = Color.Black;
            VG32.BorderWidth = 2;
            VG32.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void VG_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }

        private void FR_Clicked(object sender, EventArgs e)
        {
            highlightFRBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
    }
}