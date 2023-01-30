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
    public class recipeInfo
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://capstoneproject-b8d68-default-rtdb.asia-southeast1.firebasedatabase.app/");
        FirebaseStorage firebaseStorage = new FirebaseStorage("capstoneproject-b8d68.appspot.com");
        public async Task<bool> Save(recipeInfoModel recipe)
        {
            try
            {
                await firebaseClient.Child(nameof(recipeInfoModel))
                                .Child(EnterRecipeDetailspt2.recipeID)
                                .PutAsync(JsonConvert.SerializeObject(recipe));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<List<recipeInfoModel>> GetAll()
        {
            return (await firebaseClient.Child(nameof(recipeInfoModel)).OnceAsync<recipeInfoModel>()).Select(item => new recipeInfoModel
            {
                RecipeName = item.Object.RecipeName,
                RecipeAuthor = item.Object.RecipeAuthor,
                RecipeDescription = item.Object.RecipeDescription,
                RecipeCookTime = item.Object.RecipeCookTime,
                RecipePrepTime = item.Object.RecipePrepTime,
                RecipeInstructions = item.Object.RecipeInstructions,
                RecipeIngredients = item.Object.RecipeIngredients,
                RecipeIMG = item.Object.RecipeIMG,
                RecipeID = item.Key
            }).ToList();
        }
        public async Task<List<recipeInfoModel>> GetAllByName(string name)
        {
            return (await firebaseClient.Child(nameof(recipeInfoModel)).OnceAsync<recipeInfoModel>()).Select(item => new recipeInfoModel
            {
                RecipeName = item.Object.RecipeName,
                RecipeAuthor = item.Object.RecipeAuthor,
                RecipeDescription = item.Object.RecipeDescription,
                RecipeCookTime = item.Object.RecipeCookTime,
                RecipePrepTime = item.Object.RecipePrepTime,
                RecipeInstructions = item.Object.RecipeInstructions,
                RecipeIngredients = item.Object.RecipeIngredients,
                RecipeIMG = item.Object.RecipeIMG,
                RecipeID = item.Key
            }).Where(c => c.RecipeName.ToLower().Contains(name.ToLower())).ToList();
        }
        public async Task<List<recipeInfoModel>> OutputRecipe(string name)
        {
            return (await firebaseClient.Child(nameof(recipeInfoModel)).OnceAsync<recipeInfoModel>()).Select(item => new recipeInfoModel
            {
                RecipeName = item.Object.RecipeName,
                RecipeAuthor = item.Object.RecipeAuthor,
                RecipeDescription = item.Object.RecipeDescription,
                RecipeCookTime = item.Object.RecipeCookTime,
                RecipePrepTime = item.Object.RecipePrepTime,
                RecipeInstructions = item.Object.RecipeInstructions,
                RecipeIngredients = item.Object.RecipeIngredients,
                RecipeIMG = item.Object.RecipeIMG,
                RecipeID = item.Key
            }).Where(c => c.RecipeIngredients.ToLower().Contains(name.ToLower())).ToList();
        }
        //public async Task<List<recipeInfoModel>> RandomRecipes()
        //{
        //    var random = new Random();
        //    int randomIndex = random.Next(1, 170);

        //    return (await firebaseClient.Child(nameof(recipeInfoModel)).Child(randomIndex.ToString()).OnceAsync<recipeInfoModel>()).Select(item => new recipeInfoModel
        //    {
        //        RecipeName = item.Object.RecipeName,
        //        RecipeAuthor = item.Object.RecipeAuthor,
        //        RecipeDescription = item.Object.RecipeDescription,
        //        RecipeCookTime = item.Object.RecipeCookTime,
        //        RecipePrepTime = item.Object.RecipePrepTime,
        //        RecipeInstructions = item.Object.RecipeInstructions,
        //        RecipeIngredients = item.Object.RecipeIngredients,
        //        RecipeIMG = item.Object.RecipeIMG,
        //        RecipeID = item.Key
        //    }).ToList();
        //}
        public async Task<string> UploadFile(Stream fileStream, string fileName)
        {
            var image = await firebaseStorage.Child("RecipeIMG").Child(fileName).PutAsync(fileStream);
            return image;
        }

    }
}
