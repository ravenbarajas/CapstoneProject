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

            FR30.BackgroundColor = Color.White;
            FR30.TextColor = Color.Black;
            FR30.BorderWidth = 2;
            FR30.BorderColor = Color.FromRgb(30, 64, 114);

            FR31.BackgroundColor = Color.White;
            FR31.TextColor = Color.Black;
            FR31.BorderWidth = 2;
            FR31.BorderColor = Color.FromRgb(30, 64, 114);

            FR32.BackgroundColor = Color.White;
            FR32.TextColor = Color.Black;
            FR32.BorderWidth = 2;
            FR32.BorderColor = Color.FromRgb(30, 64, 114);

            FR40.BackgroundColor = Color.White;
            FR40.TextColor = Color.Black;
            FR40.BorderWidth = 2;
            FR40.BorderColor = Color.FromRgb(30, 64, 114);

            FR41.BackgroundColor = Color.White;
            FR41.TextColor = Color.Black;
            FR41.BorderWidth = 2;
            FR41.BorderColor = Color.FromRgb(30, 64, 114);

            FR42.BackgroundColor = Color.White;
            FR42.TextColor = Color.Black;
            FR42.BorderWidth = 2;
            FR42.BorderColor = Color.FromRgb(30, 64, 114);

            FR50.BackgroundColor = Color.White;
            FR50.TextColor = Color.Black;
            FR50.BorderWidth = 2;
            FR50.BorderColor = Color.FromRgb(30, 64, 114);

            FR51.BackgroundColor = Color.White;
            FR51.TextColor = Color.Black;
            FR51.BorderWidth = 2;
            FR51.BorderColor = Color.FromRgb(30, 64, 114);

            FR52.BackgroundColor = Color.White;
            FR52.TextColor = Color.Black;
            FR52.BorderWidth = 2;
            FR52.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightDRBTN()
        {
            DR00.BackgroundColor = Color.White;
            DR00.TextColor = Color.Black;
            DR00.BorderWidth = 2;
            DR00.BorderColor = Color.FromRgb(30, 64, 114);

            DR01.BackgroundColor = Color.White;
            DR01.TextColor = Color.Black;
            DR01.BorderWidth = 2;
            DR01.BorderColor = Color.FromRgb(30, 64, 114);

            DR02.BackgroundColor = Color.White;
            DR02.TextColor = Color.Black;
            DR02.BorderWidth = 2;
            DR02.BorderColor = Color.FromRgb(30, 64, 114);

            DR10.BackgroundColor = Color.White;
            DR10.TextColor = Color.Black;
            DR10.BorderWidth = 2;
            DR10.BorderColor = Color.FromRgb(30, 64, 114);

            DR11.BackgroundColor = Color.White;
            DR11.TextColor = Color.Black;
            DR11.BorderWidth = 2;
            DR11.BorderColor = Color.FromRgb(30, 64, 114);

            DR12.BackgroundColor = Color.White;
            DR12.TextColor = Color.Black;
            DR12.BorderWidth = 2;
            DR12.BorderColor = Color.FromRgb(30, 64, 114);

            DR20.BackgroundColor = Color.White;
            DR20.TextColor = Color.Black;
            DR20.BorderWidth = 2;
            DR20.BorderColor = Color.FromRgb(30, 64, 114);

            DR21.BackgroundColor = Color.White;
            DR21.TextColor = Color.Black;
            DR21.BorderWidth = 2;
            DR21.BorderColor = Color.FromRgb(30, 64, 114);

            DR22.BackgroundColor = Color.White;
            DR22.TextColor = Color.Black;
            DR22.BorderWidth = 2;
            DR22.BorderColor = Color.FromRgb(30, 64, 114);

            DR30.BackgroundColor = Color.White;
            DR30.TextColor = Color.Black;
            DR30.BorderWidth = 2;
            DR30.BorderColor = Color.FromRgb(30, 64, 114);

            DR31.BackgroundColor = Color.White;
            DR31.TextColor = Color.Black;
            DR31.BorderWidth = 2;
            DR31.BorderColor = Color.FromRgb(30, 64, 114);

            DR32.BackgroundColor = Color.White;
            DR32.TextColor = Color.Black;
            DR32.BorderWidth = 2;
            DR32.BorderColor = Color.FromRgb(30, 64, 114);

            DR40.BackgroundColor = Color.White;
            DR40.TextColor = Color.Black;
            DR40.BorderWidth = 2;
            DR40.BorderColor = Color.FromRgb(30, 64, 114);

            DR41.BackgroundColor = Color.White;
            DR41.TextColor = Color.Black;
            DR41.BorderWidth = 2;
            DR41.BorderColor = Color.FromRgb(30, 64, 114);

            DR42.BackgroundColor = Color.White;
            DR42.TextColor = Color.Black;
            DR42.BorderWidth = 2;
            DR42.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightDFBTN()
        {
            DF00.BackgroundColor = Color.White;
            DF00.TextColor = Color.Black;
            DF00.BorderWidth = 2;
            DF00.BorderColor = Color.FromRgb(30, 64, 114);

            DF01.BackgroundColor = Color.White;
            DF01.TextColor = Color.Black;
            DF01.BorderWidth = 2;
            DF01.BorderColor = Color.FromRgb(30, 64, 114);

            DF02.BackgroundColor = Color.White;
            DF02.TextColor = Color.Black;
            DF02.BorderWidth = 2;
            DF02.BorderColor = Color.FromRgb(30, 64, 114);

            DF10.BackgroundColor = Color.White;
            DF10.TextColor = Color.Black;
            DF10.BorderWidth = 2;
            DF10.BorderColor = Color.FromRgb(30, 64, 114);

            DF11.BackgroundColor = Color.White;
            DF11.TextColor = Color.Black;
            DF11.BorderWidth = 2;
            DF11.BorderColor = Color.FromRgb(30, 64, 114);

            DF12.BackgroundColor = Color.White;
            DF12.TextColor = Color.Black;
            DF12.BorderWidth = 2;
            DF12.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightPBBTN()
        {
            PB00.BackgroundColor = Color.White;
            PB00.TextColor = Color.Black;
            PB00.BorderWidth = 2;
            PB00.BorderColor = Color.FromRgb(30, 64, 114);

            PB01.BackgroundColor = Color.White;
            PB01.TextColor = Color.Black;
            PB01.BorderWidth = 2;
            PB01.BorderColor = Color.FromRgb(30, 64, 114);

            PB02.BackgroundColor = Color.White;
            PB02.TextColor = Color.Black;
            PB02.BorderWidth = 2;
            PB02.BorderColor = Color.FromRgb(30, 64, 114);

            PB10.BackgroundColor = Color.White;
            PB10.TextColor = Color.Black;
            PB10.BorderWidth = 2;
            PB10.BorderColor = Color.FromRgb(30, 64, 114);

            PB11.BackgroundColor = Color.White;
            PB11.TextColor = Color.Black;
            PB11.BorderWidth = 2;
            PB11.BorderColor = Color.FromRgb(30, 64, 114);

            PB12.BackgroundColor = Color.White;
            PB12.TextColor = Color.Black;
            PB12.BorderWidth = 2;
            PB12.BorderColor = Color.FromRgb(30, 64, 114);

            PB20.BackgroundColor = Color.White;
            PB20.TextColor = Color.Black;
            PB20.BorderWidth = 2;
            PB20.BorderColor = Color.FromRgb(30, 64, 114);

            PB21.BackgroundColor = Color.White;
            PB21.TextColor = Color.Black;
            PB21.BorderWidth = 2;
            PB21.BorderColor = Color.FromRgb(30, 64, 114);

            PB22.BackgroundColor = Color.White;
            PB22.TextColor = Color.Black;
            PB22.BorderWidth = 2;
            PB22.BorderColor = Color.FromRgb(30, 64, 114);

            PB30.BackgroundColor = Color.White;
            PB30.TextColor = Color.Black;
            PB30.BorderWidth = 2;
            PB30.BorderColor = Color.FromRgb(30, 64, 114);

            PB31.BackgroundColor = Color.White;
            PB31.TextColor = Color.Black;
            PB31.BorderWidth = 2;
            PB31.BorderColor = Color.FromRgb(30, 64, 114);

            PB32.BackgroundColor = Color.White;
            PB32.TextColor = Color.Black;
            PB32.BorderWidth = 2;
            PB32.BorderColor = Color.FromRgb(30, 64, 114);

            PB40.BackgroundColor = Color.White;
            PB40.TextColor = Color.Black;
            PB40.BorderWidth = 2;
            PB40.BorderColor = Color.FromRgb(30, 64, 114);

            PB41.BackgroundColor = Color.White;
            PB41.TextColor = Color.Black;
            PB41.BorderWidth = 2;
            PB41.BorderColor = Color.FromRgb(30, 64, 114);

            PB42.BackgroundColor = Color.White;
            PB42.TextColor = Color.Black;
            PB42.BorderWidth = 2;
            PB42.BorderColor = Color.FromRgb(30, 64, 114);

            PB50.BackgroundColor = Color.White;
            PB50.TextColor = Color.Black;
            PB50.BorderWidth = 2;
            PB50.BorderColor = Color.FromRgb(30, 64, 114);

            PB51.BackgroundColor = Color.White;
            PB51.TextColor = Color.Black;
            PB51.BorderWidth = 2;
            PB51.BorderColor = Color.FromRgb(30, 64, 114);

            PB52.BackgroundColor = Color.White;
            PB52.TextColor = Color.Black;
            PB52.BorderWidth = 2;
            PB52.BorderColor = Color.FromRgb(30, 64, 114);

            PB60.BackgroundColor = Color.White;
            PB60.TextColor = Color.Black;
            PB60.BorderWidth = 2;
            PB60.BorderColor = Color.FromRgb(30, 64, 114);

            PB61.BackgroundColor = Color.White;
            PB61.TextColor = Color.Black;
            PB61.BorderWidth = 2;
            PB61.BorderColor = Color.FromRgb(30, 64, 114);

            PB62.BackgroundColor = Color.White;
            PB62.TextColor = Color.Black;
            PB62.BorderWidth = 2;
            PB62.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightCKBTN()
        {
            CK00.BackgroundColor = Color.White;
            CK00.TextColor = Color.Black;
            CK00.BorderWidth = 2;
            CK00.BorderColor = Color.FromRgb(30, 64, 114);

            CK01.BackgroundColor = Color.White;
            CK01.TextColor = Color.Black;
            CK01.BorderWidth = 2;
            CK01.BorderColor = Color.FromRgb(30, 64, 114);

            CK02.BackgroundColor = Color.White;
            CK02.TextColor = Color.Black;
            CK02.BorderWidth = 2;
            CK02.BorderColor = Color.FromRgb(30, 64, 114);

            CK10.BackgroundColor = Color.White;
            CK10.TextColor = Color.Black;
            CK10.BorderWidth = 2;
            CK10.BorderColor = Color.FromRgb(30, 64, 114);

            CK11.BackgroundColor = Color.White;
            CK11.TextColor = Color.Black;
            CK11.BorderWidth = 2;
            CK11.BorderColor = Color.FromRgb(30, 64, 114);

            CK12.BackgroundColor = Color.White;
            CK12.TextColor = Color.Black;
            CK12.BorderWidth = 2;
            CK12.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightSFBTN()
        {
            SF00.BackgroundColor = Color.White;
            SF00.TextColor = Color.Black;
            SF00.BorderWidth = 2;
            SF00.BorderColor = Color.FromRgb(30, 64, 114);

            SF01.BackgroundColor = Color.White;
            SF01.TextColor = Color.Black;
            SF01.BorderWidth = 2;
            SF01.BorderColor = Color.FromRgb(30, 64, 114);

            SF02.BackgroundColor = Color.White;
            SF02.TextColor = Color.Black;
            SF02.BorderWidth = 2;
            SF02.BorderColor = Color.FromRgb(30, 64, 114);

            SF10.BackgroundColor = Color.White;
            SF10.TextColor = Color.Black;
            SF10.BorderWidth = 2;
            SF10.BorderColor = Color.FromRgb(30, 64, 114);

            SF11.BackgroundColor = Color.White;
            SF11.TextColor = Color.Black;
            SF11.BorderWidth = 2;
            SF11.BorderColor = Color.FromRgb(30, 64, 114);

            SF12.BackgroundColor = Color.White;
            SF12.TextColor = Color.Black;
            SF12.BorderWidth = 2;
            SF12.BorderColor = Color.FromRgb(30, 64, 114);

            SF20.BackgroundColor = Color.White;
            SF20.TextColor = Color.Black;
            SF20.BorderWidth = 2;
            SF20.BorderColor = Color.FromRgb(30, 64, 114);

            SF21.BackgroundColor = Color.White;
            SF21.TextColor = Color.Black;
            SF21.BorderWidth = 2;
            SF21.BorderColor = Color.FromRgb(30, 64, 114);

            SF22.BackgroundColor = Color.White;
            SF22.TextColor = Color.Black;
            SF22.BorderWidth = 2;
            SF22.BorderColor = Color.FromRgb(30, 64, 114);

            SF30.BackgroundColor = Color.White;
            SF30.TextColor = Color.Black;
            SF30.BorderWidth = 2;
            SF30.BorderColor = Color.FromRgb(30, 64, 114);

            SF31.BackgroundColor = Color.White;
            SF31.TextColor = Color.Black;
            SF31.BorderWidth = 2;
            SF31.BorderColor = Color.FromRgb(30, 64, 114);

            SF32.BackgroundColor = Color.White;
            SF32.TextColor = Color.Black;
            SF32.BorderWidth = 2;
            SF32.BorderColor = Color.FromRgb(30, 64, 114);

            SF40.BackgroundColor = Color.White;
            SF40.TextColor = Color.Black;
            SF40.BorderWidth = 2;
            SF40.BorderColor = Color.FromRgb(30, 64, 114);

            SF41.BackgroundColor = Color.White;
            SF41.TextColor = Color.Black;
            SF41.BorderWidth = 2;
            SF41.BorderColor = Color.FromRgb(30, 64, 114);

            SF42.BackgroundColor = Color.White;
            SF42.TextColor = Color.Black;
            SF42.BorderWidth = 2;
            SF42.BorderColor = Color.FromRgb(30, 64, 114);

            SF50.BackgroundColor = Color.White;
            SF50.TextColor = Color.Black;
            SF50.BorderWidth = 2;
            SF50.BorderColor = Color.FromRgb(30, 64, 114);

            SF51.BackgroundColor = Color.White;
            SF51.TextColor = Color.Black;
            SF51.BorderWidth = 2;
            SF51.BorderColor = Color.FromRgb(30, 64, 114);

            SF52.BackgroundColor = Color.White;
            SF52.TextColor = Color.Black;
            SF52.BorderWidth = 2;
            SF52.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightBKBTN()
        {
            BK00.BackgroundColor = Color.White;
            BK00.TextColor = Color.Black;
            BK00.BorderWidth = 2;
            BK00.BorderColor = Color.FromRgb(30, 64, 114);

            BK01.BackgroundColor = Color.White;
            BK01.TextColor = Color.Black;
            BK01.BorderWidth = 2;
            BK01.BorderColor = Color.FromRgb(30, 64, 114);

            BK02.BackgroundColor = Color.White;
            BK02.TextColor = Color.Black;
            BK02.BorderWidth = 2;
            BK02.BorderColor = Color.FromRgb(30, 64, 114);

            BK10.BackgroundColor = Color.White;
            BK10.TextColor = Color.Black;
            BK10.BorderWidth = 2;
            BK10.BorderColor = Color.FromRgb(30, 64, 114);

            BK11.BackgroundColor = Color.White;
            BK11.TextColor = Color.Black;
            BK11.BorderWidth = 2;
            BK11.BorderColor = Color.FromRgb(30, 64, 114);

            BK12.BackgroundColor = Color.White;
            BK12.TextColor = Color.Black;
            BK12.BorderWidth = 2;
            BK12.BorderColor = Color.FromRgb(30, 64, 114);

            BK20.BackgroundColor = Color.White;
            BK20.TextColor = Color.Black;
            BK20.BorderWidth = 2;
            BK20.BorderColor = Color.FromRgb(30, 64, 114);

            BK21.BackgroundColor = Color.White;
            BK21.TextColor = Color.Black;
            BK21.BorderWidth = 2;
            BK21.BorderColor = Color.FromRgb(30, 64, 114);

            BK22.BackgroundColor = Color.White;
            BK22.TextColor = Color.Black;
            BK22.BorderWidth = 2;
            BK22.BorderColor = Color.FromRgb(30, 64, 114);

            BK30.BackgroundColor = Color.White;
            BK30.TextColor = Color.Black;
            BK30.BorderWidth = 2;
            BK30.BorderColor = Color.FromRgb(30, 64, 114);

            BK31.BackgroundColor = Color.White;
            BK31.TextColor = Color.Black;
            BK31.BorderWidth = 2;
            BK31.BorderColor = Color.FromRgb(30, 64, 114);

            BK32.BackgroundColor = Color.White;
            BK32.TextColor = Color.Black;
            BK32.BorderWidth = 2;
            BK32.BorderColor = Color.FromRgb(30, 64, 114);

            BK40.BackgroundColor = Color.White;
            BK40.TextColor = Color.Black;
            BK40.BorderWidth = 2;
            BK40.BorderColor = Color.FromRgb(30, 64, 114);

            BK41.BackgroundColor = Color.White;
            BK41.TextColor = Color.Black;
            BK41.BorderWidth = 2;
            BK41.BorderColor = Color.FromRgb(30, 64, 114);

            BK42.BackgroundColor = Color.White;
            BK42.TextColor = Color.Black;
            BK42.BorderWidth = 2;
            BK42.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightDWBTN()
        {
            DW00.BackgroundColor = Color.White;
            DW00.TextColor = Color.Black;
            DW00.BorderWidth = 2;
            DW00.BorderColor = Color.FromRgb(30, 64, 114);

            DW01.BackgroundColor = Color.White;
            DW01.TextColor = Color.Black;
            DW01.BorderWidth = 2;
            DW01.BorderColor = Color.FromRgb(30, 64, 114);

            DW02.BackgroundColor = Color.White;
            DW02.TextColor = Color.Black;
            DW02.BorderWidth = 2;
            DW02.BorderColor = Color.FromRgb(30, 64, 114);

            DW10.BackgroundColor = Color.White;
            DW10.TextColor = Color.Black;
            DW10.BorderWidth = 2;
            DW10.BorderColor = Color.FromRgb(30, 64, 114);

            DW11.BackgroundColor = Color.White;
            DW11.TextColor = Color.Black;
            DW11.BorderWidth = 2;
            DW11.BorderColor = Color.FromRgb(30, 64, 114);

            DW12.BackgroundColor = Color.White;
            DW12.TextColor = Color.Black;
            DW12.BorderWidth = 2;
            DW12.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightPSBTN()
        {
            PS00.BackgroundColor = Color.White;
            PS00.TextColor = Color.Black;
            PS00.BorderWidth = 2;
            PS00.BorderColor = Color.FromRgb(30, 64, 114);

            PS01.BackgroundColor = Color.White;
            PS01.TextColor = Color.Black;
            PS01.BorderWidth = 2;
            PS01.BorderColor = Color.FromRgb(30, 64, 114);

            PS02.BackgroundColor = Color.White;
            PS02.TextColor = Color.Black;
            PS02.BorderWidth = 2;
            PS02.BorderColor = Color.FromRgb(30, 64, 114);

            PS10.BackgroundColor = Color.White;
            PS10.TextColor = Color.Black;
            PS10.BorderWidth = 2;
            PS10.BorderColor = Color.FromRgb(30, 64, 114);

            PS11.BackgroundColor = Color.White;
            PS11.TextColor = Color.Black;
            PS11.BorderWidth = 2;
            PS11.BorderColor = Color.FromRgb(30, 64, 114);

            PS12.BackgroundColor = Color.White;
            PS12.TextColor = Color.Black;
            PS12.BorderWidth = 2;
            PS12.BorderColor = Color.FromRgb(30, 64, 114);

            PS20.BackgroundColor = Color.White;
            PS20.TextColor = Color.Black;
            PS20.BorderWidth = 2;
            PS20.BorderColor = Color.FromRgb(30, 64, 114);

            PS21.BackgroundColor = Color.White;
            PS21.TextColor = Color.Black;
            PS21.BorderWidth = 2;
            PS21.BorderColor = Color.FromRgb(30, 64, 114);

            PS22.BackgroundColor = Color.White;
            PS22.TextColor = Color.Black;
            PS22.BorderWidth = 2;
            PS22.BorderColor = Color.FromRgb(30, 64, 114);

            PS30.BackgroundColor = Color.White;
            PS30.TextColor = Color.Black;
            PS30.BorderWidth = 2;
            PS30.BorderColor = Color.FromRgb(30, 64, 114);

            PS31.BackgroundColor = Color.White;
            PS31.TextColor = Color.Black;
            PS31.BorderWidth = 2;
            PS31.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightSNBTN()
        {
            SN00.BackgroundColor = Color.White;
            SN00.TextColor = Color.Black;
            SN00.BorderWidth = 2;
            SN00.BorderColor = Color.FromRgb(30, 64, 114);

            SN01.BackgroundColor = Color.White;
            SN01.TextColor = Color.Black;
            SN01.BorderWidth = 2;
            SN01.BorderColor = Color.FromRgb(30, 64, 114);

            SN02.BackgroundColor = Color.White;
            SN02.TextColor = Color.Black;
            SN02.BorderWidth = 2;
            SN02.BorderColor = Color.FromRgb(30, 64, 114);

            SN10.BackgroundColor = Color.White;
            SN10.TextColor = Color.Black;
            SN10.BorderWidth = 2;
            SN10.BorderColor = Color.FromRgb(30, 64, 114);

            SN11.BackgroundColor = Color.White;
            SN11.TextColor = Color.Black;
            SN11.BorderWidth = 2;
            SN11.BorderColor = Color.FromRgb(30, 64, 114);

            SN12.BackgroundColor = Color.White;
            SN12.TextColor = Color.Black;
            SN12.BorderWidth = 2;
            SN12.BorderColor = Color.FromRgb(30, 64, 114);

            SN20.BackgroundColor = Color.White;
            SN20.TextColor = Color.Black;
            SN20.BorderWidth = 2;
            SN20.BorderColor = Color.FromRgb(30, 64, 114);

            SN21.BackgroundColor = Color.White;
            SN21.TextColor = Color.Black;
            SN21.BorderWidth = 2;
            SN21.BorderColor = Color.FromRgb(30, 64, 114);

            SN22.BackgroundColor = Color.White;
            SN22.TextColor = Color.Black;
            SN22.BorderWidth = 2;
            SN22.BorderColor = Color.FromRgb(30, 64, 114);

            SN30.BackgroundColor = Color.White;
            SN30.TextColor = Color.Black;
            SN30.BorderWidth = 2;
            SN30.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightSWBTN()
        {
            SW00.BackgroundColor = Color.White;
            SW00.TextColor = Color.Black;
            SW00.BorderWidth = 2;
            SW00.BorderColor = Color.FromRgb(30, 64, 114);

            SW01.BackgroundColor = Color.White;
            SW01.TextColor = Color.Black;
            SW01.BorderWidth = 2;
            SW01.BorderColor = Color.FromRgb(30, 64, 114);

            SW02.BackgroundColor = Color.White;
            SW02.TextColor = Color.Black;
            SW02.BorderWidth = 2;
            SW02.BorderColor = Color.FromRgb(30, 64, 114);

            SW10.BackgroundColor = Color.White;
            SW10.TextColor = Color.Black;
            SW10.BorderWidth = 2;
            SW10.BorderColor = Color.FromRgb(30, 64, 114);

            SW11.BackgroundColor = Color.White;
            SW11.TextColor = Color.Black;
            SW11.BorderWidth = 2;
            SW11.BorderColor = Color.FromRgb(30, 64, 114);

            SW12.BackgroundColor = Color.White;
            SW12.TextColor = Color.Black;
            SW12.BorderWidth = 2;
            SW12.BorderColor = Color.FromRgb(30, 64, 114);

            SW20.BackgroundColor = Color.White;
            SW20.TextColor = Color.Black;
            SW20.BorderWidth = 2;
            SW20.BorderColor = Color.FromRgb(30, 64, 114);

            SW21.BackgroundColor = Color.White;
            SW21.TextColor = Color.Black;
            SW21.BorderWidth = 2;
            SW21.BorderColor = Color.FromRgb(30, 64, 114);

            SW22.BackgroundColor = Color.White;
            SW22.TextColor = Color.Black;
            SW22.BorderWidth = 2;
            SW22.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightCNBTN()
        {
            CN00.BackgroundColor = Color.White;
            CN00.TextColor = Color.Black;
            CN00.BorderWidth = 2;
            CN00.BorderColor = Color.FromRgb(30, 64, 114);

            CN01.BackgroundColor = Color.White;
            CN01.TextColor = Color.Black;
            CN01.BorderWidth = 2;
            CN01.BorderColor = Color.FromRgb(30, 64, 114);

            CN02.BackgroundColor = Color.White;
            CN02.TextColor = Color.Black;
            CN02.BorderWidth = 2;
            CN02.BorderColor = Color.FromRgb(30, 64, 114);

            CN10.BackgroundColor = Color.White;
            CN10.TextColor = Color.Black;
            CN10.BorderWidth = 2;
            CN10.BorderColor = Color.FromRgb(30, 64, 114);

            CN11.BackgroundColor = Color.White;
            CN11.TextColor = Color.Black;
            CN11.BorderWidth = 2;
            CN11.BorderColor = Color.FromRgb(30, 64, 114);

            CN12.BackgroundColor = Color.White;
            CN12.TextColor = Color.Black;
            CN12.BorderWidth = 2;
            CN12.BorderColor = Color.FromRgb(30, 64, 114);

            CN20.BackgroundColor = Color.White;
            CN20.TextColor = Color.Black;
            CN20.BorderWidth = 2;
            CN20.BorderColor = Color.FromRgb(30, 64, 114);

            CN21.BackgroundColor = Color.White;
            CN21.TextColor = Color.Black;
            CN21.BorderWidth = 2;
            CN21.BorderColor = Color.FromRgb(30, 64, 114);

            CN22.BackgroundColor = Color.White;
            CN22.TextColor = Color.Black;
            CN22.BorderWidth = 2;
            CN22.BorderColor = Color.FromRgb(30, 64, 114);

            CN30.BackgroundColor = Color.White;
            CN30.TextColor = Color.Black;
            CN30.BorderWidth = 2;
            CN30.BorderColor = Color.FromRgb(30, 64, 114);

            CN31.BackgroundColor = Color.White;
            CN31.TextColor = Color.Black;
            CN31.BorderWidth = 2;
            CN31.BorderColor = Color.FromRgb(30, 64, 114);

            CN32.BackgroundColor = Color.White;
            CN32.TextColor = Color.Black;
            CN32.BorderWidth = 2;
            CN32.BorderColor = Color.FromRgb(30, 64, 114);

            CN40.BackgroundColor = Color.White;
            CN40.TextColor = Color.Black;
            CN40.BorderWidth = 2;
            CN40.BorderColor = Color.FromRgb(30, 64, 114);

            CN41.BackgroundColor = Color.White;
            CN41.TextColor = Color.Black;
            CN41.BorderWidth = 2;
            CN41.BorderColor = Color.FromRgb(30, 64, 114);

            CN42.BackgroundColor = Color.White;
            CN42.TextColor = Color.Black;
            CN42.BorderWidth = 2;
            CN42.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightHSBTN()
        {
            HS00.BackgroundColor = Color.White;
            HS00.TextColor = Color.Black;
            HS00.BorderWidth = 2;
            HS00.BorderColor = Color.FromRgb(30, 64, 114);

            HS01.BackgroundColor = Color.White;
            HS01.TextColor = Color.Black;
            HS01.BorderWidth = 2;
            HS01.BorderColor = Color.FromRgb(30, 64, 114);

            HS02.BackgroundColor = Color.White;
            HS02.TextColor = Color.Black;
            HS02.BorderWidth = 2;
            HS02.BorderColor = Color.FromRgb(30, 64, 114);

            HS10.BackgroundColor = Color.White;
            HS10.TextColor = Color.Black;
            HS10.BorderWidth = 2;
            HS10.BorderColor = Color.FromRgb(30, 64, 114);

            HS11.BackgroundColor = Color.White;
            HS11.TextColor = Color.Black;
            HS11.BorderWidth = 2;
            HS11.BorderColor = Color.FromRgb(30, 64, 114);

            HS12.BackgroundColor = Color.White;
            HS12.TextColor = Color.Black;
            HS12.BorderWidth = 2;
            HS12.BorderColor = Color.FromRgb(30, 64, 114);

            HS20.BackgroundColor = Color.White;
            HS20.TextColor = Color.Black;
            HS20.BorderWidth = 2;
            HS20.BorderColor = Color.FromRgb(30, 64, 114);

            HS21.BackgroundColor = Color.White;
            HS21.TextColor = Color.Black;
            HS21.BorderWidth = 2;
            HS21.BorderColor = Color.FromRgb(30, 64, 114);

            HS22.BackgroundColor = Color.White;
            HS22.TextColor = Color.Black;
            HS22.BorderWidth = 2;
            HS22.BorderColor = Color.FromRgb(30, 64, 114);

            HS30.BackgroundColor = Color.White;
            HS30.TextColor = Color.Black;
            HS30.BorderWidth = 2;
            HS30.BorderColor = Color.FromRgb(30, 64, 114);

            HS31.BackgroundColor = Color.White;
            HS31.TextColor = Color.Black;
            HS31.BorderWidth = 2;
            HS31.BorderColor = Color.FromRgb(30, 64, 114);

            HS32.BackgroundColor = Color.White;
            HS32.TextColor = Color.Black;
            HS32.BorderWidth = 2;
            HS32.BorderColor = Color.FromRgb(30, 64, 114);

            HS40.BackgroundColor = Color.White;
            HS40.TextColor = Color.Black;
            HS40.BorderWidth = 2;
            HS40.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightSDBTN()
        {
            SD00.BackgroundColor = Color.White;
            SD00.TextColor = Color.Black;
            SD00.BorderWidth = 2;
            SD00.BorderColor = Color.FromRgb(30, 64, 114);

            SD01.BackgroundColor = Color.White;
            SD01.TextColor = Color.Black;
            SD01.BorderWidth = 2;
            SD01.BorderColor = Color.FromRgb(30, 64, 114);

            SD02.BackgroundColor = Color.White;
            SD02.TextColor = Color.Black;
            SD02.BorderWidth = 2;
            SD02.BorderColor = Color.FromRgb(30, 64, 114);

            SD10.BackgroundColor = Color.White;
            SD10.TextColor = Color.Black;
            SD10.BorderWidth = 2;
            SD10.BorderColor = Color.FromRgb(30, 64, 114);

            SD11.BackgroundColor = Color.White;
            SD11.TextColor = Color.Black;
            SD11.BorderWidth = 2;
            SD11.BorderColor = Color.FromRgb(30, 64, 114);

            SD12.BackgroundColor = Color.White;
            SD12.TextColor = Color.Black;
            SD12.BorderWidth = 2;
            SD12.BorderColor = Color.FromRgb(30, 64, 114);

            SD20.BackgroundColor = Color.White;
            SD20.TextColor = Color.Black;
            SD20.BorderWidth = 2;
            SD20.BorderColor = Color.FromRgb(30, 64, 114);

            SD21.BackgroundColor = Color.White;
            SD21.TextColor = Color.Black;
            SD21.BorderWidth = 2;
            SD21.BorderColor = Color.FromRgb(30, 64, 114);

            SD22.BackgroundColor = Color.White;
            SD22.TextColor = Color.Black;
            SD22.BorderWidth = 2;
            SD22.BorderColor = Color.FromRgb(30, 64, 114);

            SD30.BackgroundColor = Color.White;
            SD30.TextColor = Color.Black;
            SD30.BorderWidth = 2;
            SD30.BorderColor = Color.FromRgb(30, 64, 114);

            SD31.BackgroundColor = Color.White;
            SD31.TextColor = Color.Black;
            SD31.BorderWidth = 2;
            SD31.BorderColor = Color.FromRgb(30, 64, 114);

            SD32.BackgroundColor = Color.White;
            SD32.TextColor = Color.Black;
            SD32.BorderWidth = 2;
            SD32.BorderColor = Color.FromRgb(30, 64, 114);
        }
        private void highlightINGBTN()
        {
            All.BackgroundColor = Color.FromRgb(127, 132, 135);
            All.TextColor = Color.White;

            VegetablesFruits.BackgroundColor = Color.FromRgb(127, 132, 135);
            VegetablesFruits.TextColor = Color.White;

            DairyProducts.BackgroundColor = Color.FromRgb(127, 132, 135);
            DairyProducts.TextColor = Color.White;

            MeatProducts.BackgroundColor = Color.FromRgb(127, 132, 135);
            MeatProducts.TextColor = Color.White;

            GrainProducts.BackgroundColor = Color.FromRgb(127, 132, 135);
            GrainProducts.TextColor = Color.White;

            Dessert.BackgroundColor = Color.FromRgb(127, 132, 135);
            Dessert.TextColor = Color.White;

            Condiments.BackgroundColor = Color.FromRgb(127, 132, 135);
            Condiments.TextColor = Color.White;
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
        private void DR_Clicked(object sender, EventArgs e)
        {
            highlightDRBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void DF_Clicked(object sender, EventArgs e)
        {
            highlightDFBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void PB_Clicked(object sender, EventArgs e)
        {
            highlightPBBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void CK_Clicked(object sender, EventArgs e)
        {
            highlightCKBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void SF_Clicked(object sender, EventArgs e)
        {
            highlightSFBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void BK_Clicked(object sender, EventArgs e)
        {
            highlightBKBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void DW_Clicked(object sender, EventArgs e)
        {
            highlightDWBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void PS_Clicked(object sender, EventArgs e)
        {
            highlightPSBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void SN_Clicked(object sender, EventArgs e)
        {
            highlightSNBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void SW_Clicked(object sender, EventArgs e)
        {
            highlightSWBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void CN_Clicked(object sender, EventArgs e)
        {
            highlightCNBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void HS_Clicked(object sender, EventArgs e)
        {
            highlightHSBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void SD_Clicked(object sender, EventArgs e)
        {
            highlightSDBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void IngredientGroup_Clicked(object sender, EventArgs e)
        {
            highlightINGBTN();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
    }
}