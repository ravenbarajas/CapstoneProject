using Firebase.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class userProperties
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://capstoneproject-b8d68-default-rtdb.asia-southeast1.firebasedatabase.app/");
        public async Task<bool> Save(userPropertiesModel user)
        {
            var data = await firebaseClient.Child(nameof(userPropertiesModel)).PostAsync(JsonConvert.SerializeObject(user));
            if (!string.IsNullOrEmpty(data.Key))
            {
                return true;
            }
            return false;
        }
    }
}
