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
    public partial class Cookbook : ContentPage
    {
        public Cookbook()
        {
            InitializeComponent();

            var Image1 = new List<string>
            {
                "ha.jpg",
                "he.jpg",
                "hi.jpg",
                "ho.jpg",
                "hu.jpg"
            };
            Carousel1.ItemsSource = Image1;

            var Image2 = new List<string>
            {
                "ha.jpg",
                "he.jpg",
                "hi.jpg",
                "ho.jpg",
                "hu.jpg"
            };
            Carousel2.ItemsSource = Image2;

            var Image3 = new List<string>
            {
                "ha.jpg",
                "he.jpg",
                "hi.jpg",
                "ho.jpg",
                "hu.jpg"
            };
            Carousel3.ItemsSource = Image3;

            var Image4 = new List<string>
            {
                "ha.jpg",
                "he.jpg",
                "hi.jpg",
                "ho.jpg",
                "hu.jpg"
            };
            Carousel4.ItemsSource = Image4;
        }
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipePage1());
        }
    }
}