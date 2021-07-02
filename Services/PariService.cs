using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Winform.Model;

namespace Winform.Services
{
    public class PariService
    {
        public void CreerPari(Pari pari)
        {

            string endpoint = Config.apiUrl + "/pari";
            string json = JsonConvert.SerializeObject(new
            {
                description = pari.Description,
                cote = pari.Cote
            });
            using (var client = new HttpClient())
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var postTask = client.PostAsync(endpoint, httpContent);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var content = result.Content.ReadAsStringAsync();
                    content.Wait();

                    string jsonContent = content.Result;
                    JObject obj = JObject.Parse(jsonContent);
                    pari.Id = (string)obj["_id"];
                }
            }
        }
        public void AddPari(String idpari,String idmatch)
        {
            string endpoint = Config.apiUrl + "/addPari";
            string json = JsonConvert.SerializeObject(new
            {
                pari = idpari,
                match = idmatch
            });
            using (var client = new HttpClient())
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var postTask = client.PostAsync(endpoint, httpContent);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {

                }
                else
                {
                    throw new Exception("Pari non ajoute:erreur serveur possilbe");

                }
            }
        }
        public void RemovePari(string idpari,string idmatch)
        {
            string endpoint = Config.apiUrl + "/removePari";
            string json = JsonConvert.SerializeObject(new
            {
                pari = idpari,
                match = idmatch
            });
            using (var client = new HttpClient())
            {
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var postTask = client.PostAsync(endpoint, httpContent);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {

                }
                else
                {
                    throw new Exception("Pari non ajoute:erreur serveur possilbe");

                }
            }
        }
    }
    
}
