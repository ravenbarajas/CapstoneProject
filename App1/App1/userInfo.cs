using App1.Views.UserManagement;
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
    public class userInfo
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://capstoneproject-b8d68-default-rtdb.asia-southeast1.firebasedatabase.app/");
        FirebaseStorage firebaseStorage = new FirebaseStorage("capstoneproject-b8d68.appspot.com");
        public async Task<bool> Save(userInfoModel user)
        {
            try
            {
                await firebaseClient.Child(nameof(userInfoModel))
                                .Child(UserInfoPage.userID)
                                .PutAsync(JsonConvert.SerializeObject(user));
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public async Task<string> UploadFile(Stream fileStream, string fileName)
        {
            var image = await firebaseStorage.Child("UserIMG").Child(fileName).PutAsync(fileStream);
            return image;
        }
        public async Task<List<userInfoModel>> GetUserData()
        {
            return (await firebaseClient.Child(nameof(userInfoModel)).OnceAsync<userInfoModel>()).Select(item => new userInfoModel
            {
                UserID = item.Object.UserID,
                UserIMG = item.Object.UserIMG,
                Username = item.Object.Username,
                Fullname = item.Object.Fullname,
                Birthdate = item.Object.Birthdate,
                Email = item.Key
            }).ToList();
        }
        public async Task<List<userInfoModel>> UserProfileData(string name)
        {
            return (await firebaseClient.Child(nameof(userInfoModel)).OnceAsync<userInfoModel>()).Select(item => new userInfoModel
            {
                UserIMG = item.Object.UserIMG,
                Email = item.Object.Email,
                Username = item.Object.Username,
                Fullname = item.Object.Fullname,
                Birthdate = item.Object.Birthdate,
                Age = item.Object.Age,
                UserID = item.Key
            }).Where(c => c.Email.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}
