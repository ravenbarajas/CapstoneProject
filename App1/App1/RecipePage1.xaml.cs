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
    public partial class RecipePage1 : TabbedPage
    {
        public IList<Recipe1> Recipes { get; set; }
        public RecipePage1()
        {
            InitializeComponent();
            Recipes = new List<Recipe1>();
            Recipes.Add(new Recipe1() { IngredientName = "Kimchi", Quantity = "150 Grams" });
            Recipes.Add(new Recipe1() { IngredientName = "Noodles", Quantity = "100 Grams" });
            Recipes.Add(new Recipe1() { IngredientName = "Scallions", Quantity = "70 Grams" });
            Recipes.Add(new Recipe1() { IngredientName = "Spinach", Quantity = "50 Grams" });
            Recipes.Add(new Recipe1() { IngredientName = "Prawns", Quantity = "400 Grams" });
            BindingContext = this;
        }
        public class Recipe1
        {
            public string IngredientName { get; set; }
            public string Quantity { get; set; }
        }
    }
}