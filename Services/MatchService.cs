using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Winform.Model;

namespace Winform.Services
{
    public class MatchService
    {
        public static int nbresults =0;
        public static int nbrpages = 1;
        public void CreerMatch(Match match)
        {

            string endpoint = Config.apiUrl + "/match";
            string json = JsonConvert.SerializeObject(new
            {
                date_match = match.Date.ToString("yyyy-MM-dd HH:mm"),
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
        public void supprimerMatch(Match match)
        {
            try
            {

            

            string endpoint = Config.apiUrl + "/match/"+match.Id;
            WebRequest request = WebRequest.Create(endpoint);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                
            }catch(Exception exc)
            {
                throw new Exception("Une erreur s'est produite lors de la suppression");
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
        public List<Match> GetMatches(String search,bool etat,bool isToday,DateTime dateDebut,DateTime dateFin,int page,int limit)
        {
            List<Match> liste = new List<Match>();
            string endpoint = Config.apiUrl + "/matchs/search";
         
            Dictionary<string, string> body =
                new Dictionary<string, string>();
            body.Add("etat", (etat+"").ToLower());
            body.Add("page", ""+page);
            body.Add("limit", "" + limit);
            if (!string.IsNullOrEmpty(search))
            {
                body.Add("pari", search);
                body.Add("equipe", search);
            }
            if (isToday)
            {
                body.Add("isToday", (isToday+"").ToLower());
            }
            else
            {
                dateDebut = new DateTime(dateDebut.Year, dateDebut.Month, dateDebut.Day, 0, 0, 0);
                dateFin = new DateTime(dateFin.Year, dateFin.Month, dateFin.Day, 23, 59, 0);
                body.Add("date_debut", dateDebut.ToString("yyyy-MM-dd"));

                body.Add("date_fin", dateFin.ToString("yyyy-MM-dd"));
            }
            string json = JsonConvert.SerializeObject(body);
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
                    JObject o = JObject.Parse(jsonContent);
                    if (o != null)
                    {
                        String jsonArray = o.Children<JProperty>().FirstOrDefault(x => x.Name == "docs").Value.ToString();
                        JArray array = JArray.Parse(jsonArray);
                        nbresults = System.Convert.ToInt32((String)o.Children<JProperty>().FirstOrDefault(x => x.Name == "totalDocs").Value);
                        nbrpages = System.Convert.ToInt32((String)o.Children<JProperty>().FirstOrDefault(x => x.Name == "totalPages").Value);
                        foreach (var item in array)
                        {
                            Match m = item.ToObject<Match>();
                            String itemString = item.ToString();
                           
                            dynamic match = JObject.Parse(itemString);
                            m.Date = match.date_match;
                            m.Date = m.Date.AddHours(3);
                            m.LocalisationY = match.longitude;
                            m.LocalistionX = match.latitude;
                            m.Domicile = new Equipe();
                            m.Exterieur = new Equipe();
                            dynamic equipe1 = match.equipe1;
                            
                            m.Domicile.Nom = equipe1.nom;
                            m.Domicile.Avatar = equipe1.avatar;
                            m.Domicile.Id = equipe1._id;
                            dynamic equipe2 =  match.equipe2;
                            
                            m.Exterieur.Nom = equipe2.nom;
                            m.Exterieur.Avatar = equipe2.avatar;
                            m.Exterieur.Id = equipe2._id;
                            m.Etat = match.etat;
                            m.Domicile.Avatar = Config.BACKENDURL + m.Domicile.Avatar;
                            m.Exterieur.Avatar = Config.BACKENDURL + m.Exterieur.Avatar;
                            JArray ap = match.pari;
                            foreach(var i in ap)
                            {
                                String s = i.ToString();
                                dynamic pari = JObject.Parse(s);
                                Pari p = new Pari();
                                p.Id = pari._id;
                                p.Cote = pari.cote;
                                p.Description = pari.description;
                                m.ListePari.Add(p);
                            }
                            m.Description = m.Domicile.Nom + " - " + m.Exterieur.Nom;

                            //you could do a foreach or a linq here depending on what you need to do exactly with the value

                            liste.Add(m);
                        }
                    }
                }
                else
                {
                    throw new Exception("Erreur d'acces aux serveurs");
                }
            }
            return liste;
        }
    }
}
