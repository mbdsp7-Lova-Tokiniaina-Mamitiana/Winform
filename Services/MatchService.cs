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
    public class MatchService
    {
        public void CreerMatch(Match match)
        {

            string endpoint = Config.apiUrl + "/match";
            string json = JsonConvert.SerializeObject(new
            {
                date_match = match.Date.ToString("dd/MM/yyyy HH:mm:ss"),
                longitude = match.LocalistionX,
                latitude = match.LocalisationY,
                equipe1 = match.Domicile.Id,
                equipe2 = match.Exterieur.Id,
                etat = false,
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
                    match.Id = (string)obj["_id"];
                }
                else
                {
                    var content = result.Content.ReadAsStringAsync();
                    content.Wait();
                    string jsonContent = content.Result;
                    JObject obj = JObject.Parse(jsonContent);
                    String error = (string)obj["message"];
                    throw new Exception(error);
                }
            }
        }
        public void terminerMatchNode(Match match)
        {

            string endpoint = Config.apiUrl + "/terminerMatch";
            string json = JsonConvert.SerializeObject(new
            {
                match = match.Id
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
                    throw new Exception("Erreur terminer match");
                }
            }
        }
        public void terminerMatchGrails(Match match)
        {
            string endpoint = Config.apiUrGrails + "/terminermatch";
            string json = JsonConvert.SerializeObject(new
            {
                id = match.Id
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
                    throw new Exception("Erreur terminer match");
                }
            }
        }

        private void distribution(String idpari)
        {
            string endpoint = Config.apiUrGrails + "/distribution";
            string json = JsonConvert.SerializeObject(new
            {
               id = idpari
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
                    throw new Exception("Erreur distrubution des gains");
                }
            }
        }
        public void distribuerGain(List<Pari> listPari,Match match)
        {
            foreach(Pari p in listPari)
            {
                distribution(p.Id);
            }
            terminerMatchGrails(match);
            terminerMatchNode(match);
        }
    }
}
