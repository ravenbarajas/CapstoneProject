﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeGeneration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeTypePage : ContentPage
    {
        public RecipeTypePage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GroupRecipeTypePage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new PreferenceSelectionPage());
        }
    }
}