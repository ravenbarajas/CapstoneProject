using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class recipeInfoModel
    {
        public string RecipeID { get; set; }
        public string AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string RecipeIMG { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDesc { get; set; }
        public string RecipeCookTime { get; set; }
        public string RecipePrepTime { get; set; }
        public string RecipeTotalTime { get; set; }
        public string RecipeCookingProcess { get; set; }
        public string RecipeCategory { get; set; }
        public string RecipeKeywords { get; set; }
        public string RecipeInstructions { get; set; }
        public string RecipeIngredientQuantities { get; set; }
        public string RecipeIngredientMeasurements { get; set; }
        public string RecipeIngredientParts { get; set; }
        public string RecipeServings { get; set; }
        public string CalorieContent { get; set; }
        public string CholesterolContent { get; set; }
        public string SodiumContent { get; set; }
        public string CarbohydrateContent { get; set; }
        public string SugarContent { get; set; }
        public string ProteinContent { get; set; }
    }
}
