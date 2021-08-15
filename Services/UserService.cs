
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Winform.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Winform.Services
{
    class UserService
    {
        public static String token = null;
        class LoginResponse {
             bool auth;
            string token;

            public bool Auth { get => auth; set => auth = value; }
            public string Token { get => token; set => token = value; }
        }
        public User login(string login,string password)
        {
            string role = "admin";
            User user = null;
            string endpoint = Config.apiUrl + "/users/login";
            string method = "POST";
            string json = JsonConvert.SerializeObject(new
            {
                login = login,
                email = login,
                password = password,
                role = role,
            }); 
           
            using (var client = new HttpClient())
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var postTask = client.PostAsync(endpoint,httpContent);
                
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var content = result.Content.ReadAsStringAsync();
                    content.Wait();

                    string jsonContent= content.Result;
                    LoginResponse responseContent = JsonConvert.DeserializeObject<LoginResponse>(jsonContent);
                    if (responseContent.Auth)
                    {
                        token = responseContent.Token;
                        
                        user = new User(login, "", login, role);
                    }
                    else
                    {

                        throw new Exception("Information invalides");
                    }
                    
                }
                else
                {
                    if(result.StatusCode == HttpStatusCode.NotFound)
                    {
                        throw new Exception("Information invalides");
                    }
                    else
                    {
                        throw new Exception("Erreur serveur");
                    }
                }


            }
            return user;
        }
        
        public void saveToken()
        {
            BetSoccer.Properties.Settings.Default["token"] = token;
            BetSoccer.Properties.Settings.Default.Save();
        }
        public String getStorageToken()
        {
            String s = null;
            try
            {
                if (BetSoccer.Properties.Settings.Default["token"] != null)
                {
                    s = BetSoccer.Properties.Settings.Default["token"].ToString();
                }
            }
            catch (Exception)
            {

            }
          
            return s;
        }
        public void checkUserToken()
        {

        }
        public void logout()
        {
            token = "";
            saveToken();
        }
        
    }
}
