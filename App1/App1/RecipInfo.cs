using App1.Views.RecipeManagement;
using App1.Views.RecipeGeneration;
using App1.Views.UserManagement;
using App1.Views.RecipePresentation;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Storage;

namespace App1
{
    public class RecipInfo
    {
        string apiKey = "8a742d41609947928b725987f6c32a38";
        public async Task<List<Recipe>> GetRecipesByIngredients(string ingredients)
        {
            // Set up the API request
            string apiKey = "8a742d41609947928b725987f6c32a38";
            string baseUrl = "https://api.spoonacular.com/recipes/findByIngredients";
            string queryString = $"?apiKey={apiKey}&ingredients={ingredients}&number=10";

            // Send the request to the API
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(baseUrl + queryString);
            string json = await response.Content.ReadAsStringAsync();

            // Parse the JSON data
            List<Recipe> recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
            return recipes;
        }
    }
}
