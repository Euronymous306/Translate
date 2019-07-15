using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    public class TranslationService
    {
        string baseUlr = "https://translated-mymemory---translation-memory.p.rapidapi.com/api/get";

        public async Task<RootObject> TrasnlateAsync(string from, string to, string text)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));

                    client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "translated-mymemory---translation-memory.p.rapidapi.com");
                    client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "0c3f544952msh936b51bf1c8988ap193ab9jsn39ca01dd0bde");

                    var result = await client.GetAsync($"{baseUlr}?langpair={from}|{to}&q={text}");
                    var content = await result.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<RootObject>(content);
                    return data;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }


    }
}
