using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class userAuth
    {
        string ApiKey = "AIzaSyA2brPesFxaFvnSOiusWO9u5ewas-zDnok";
        FirebaseAuthProvider authProvider;
        public userAuth()
        {
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
        }
        public async Task<bool> Register(string email, string lastName, string password)
        {
            var token = await authProvider.CreateUserWithEmailAndPasswordAsync(email, lastName, password);

            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return true;
            }
            return false;
            //for testing
        }
        public async Task<string> UserLogin(string email, string password)
        {
            try
            {
                var token = await authProvider.SignInWithEmailAndPasswordAsync(email, password);



                if (!string.IsNullOrEmpty(token.FirebaseToken))
                {
                    return token.FirebaseToken;
                }
                return "";

            }
            catch (FirebaseAuthException ex)
            {

                return ex.Message;
            }
        }
    }
}
