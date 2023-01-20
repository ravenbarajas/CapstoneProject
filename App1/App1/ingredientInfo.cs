using App1.Views.RecipeManagement;
using App1.Views.RecipeGeneration;
using App1.Views.UserManagement;
using App1.Views.RecipePresentation;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Storage;

namespace App1
{
    public class ingredientInfo
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://capstoneproject-b8d68-default-rtdb.asia-southeast1.firebasedatabase.app/");
        FirebaseStorage firebaseStorage = new FirebaseStorage("capstoneproject-b8d68.appspot.com");
        public async Task<List<Ingredient>> GetAll()
        {
            return (await firebaseClient.Child(nameof(Ingredient)).OnceAsync<Ingredient>()).Select(item => new Ingredient
            {
                IngredientName = item.Object.IngredientName,
                IngredientID = item.Key
            }).ToList();
        }
        public async Task<List<Ingredient>> GetAllByName(string name)
        {
            return (await firebaseClient.Child(nameof(Ingredient)).OnceAsync<Ingredient>()).Select(item => new Ingredient
            {
                IngredientName = item.Object.IngredientName,
                IngredientID = item.Key
            }).Where(c => c.IngredientName.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}
