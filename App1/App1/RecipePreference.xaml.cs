﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipePreference : ContentPage
    {
        public RecipePreference()
        {
            InitializeComponent();
        }
        private async void VegetablesFruit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ingredient_Selection.AI_VegetablesFruit());
        }

    }
}