using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class userAuth
    {
        static string WebAPIKey = "AIzaSyA2brPesFxaFvnSOiusWO9u5ewas-zDnok";
        FirebaseAuthProvider authProvider;

        public userAuth()
        {
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIKey));
        }
        public async Task<bool> Register(string email, string username, string pass)
        {
        var token = await authProvider.CreateUserWithEmailAndPasswordAsync(email, pass, username);

            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
            return true;
            }
        return false;
        //for testing
        }
        public async Task<string>SignIn(string email, string pass)
        { 
            var token = await authProvider.SignInWithEmailAndPasswordAsync(email, pass);

            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return token.FirebaseToken;
            }
            return "";
        }
        public async Task<bool> ResetPassword(string email)
        {
            await authProvider.SendPasswordResetEmailAsync(email);
            return true;
        }

    }
}
