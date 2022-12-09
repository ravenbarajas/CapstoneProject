using App1.Views.RecipeManagement;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class recipeInfo
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://capstoneproject-b8d68-default-rtdb.asia-southeast1.firebasedatabase.app/");
        //FirebaseStorage firebaseStorage = new FirebaseStorage("xamarinfirebase-b9036.appspot.com");
        public async Task<bool> Save(recipeInfoModel recipe)
        {
            try
            {
                await firebaseClient.Child(nameof(recipeInfoModel))
                                .Child(EnterRecipeDetailspt3.recipeID)
                                .PutAsync(JsonConvert.SerializeObject(recipe));
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
