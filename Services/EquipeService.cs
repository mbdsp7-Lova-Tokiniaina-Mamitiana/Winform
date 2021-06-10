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
    class EquipeService
    {
        public List<Equipe> GetEquipes()
        {
            List<Equipe> list = new List<Equipe>();
           
            string endpoint = Config.apiUrl + "/equipes";
      

            using (var client = new HttpClient())
            {
                var httpContent = new StringContent("", Encoding.UTF8, "application/json");
                var postTask = client.GetAsync(endpoint);

                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var content = result.Content.ReadAsStringAsync();
                    content.Wait();

                    string jsonContent = content.Result;
                    var array = JArray.Parse(jsonContent);
                    foreach(var item in array)
                    {
                        Equipe equipe = item.ToObject<Equipe>();
                        var itemProperties = item.Children<JProperty>();
                        //you could do a foreach or a linq here depending on what you need to do exactly with the value
                        var myElement = itemProperties.FirstOrDefault(x => x.Name == "_id");
                        var myElementValue = myElement.Value;
                        equipe.Id = (string)myElementValue;
                        list.Add(equipe);
                    }
                 

                }
              


            }
            return list;
        }
    }
}
