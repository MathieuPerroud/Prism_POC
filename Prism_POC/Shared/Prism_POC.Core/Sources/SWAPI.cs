using Newtonsoft.Json;
using Prism_POC.Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Prism_POC.Core.Sources
{
    public class SWAPI
    {
        readonly protected string BaseAddress = @"https://swapi.dev/api/";
        private const int DefaultPage = 1;
        private const int DefaultSize = 10;

        public string GetDataResult(string url)
        {
            WebRequest request = WebRequest.Create(BaseAddress+url);
            WebResponse response = null;

            try
            {
                response = request.GetResponse();
                string json = string.Empty;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    json = reader.ReadToEnd();
                }

                return json;
            }
            catch (WebException ex)
            {
                //// TODO: Check status when there are no Internet connection. 
                return null;
            }
        }
        public ICollection<Starship> GetAllStarships(int page = DefaultPage, int size = DefaultSize)
        {
            string url = "starships/?page=" + page;
            IEnumerable<Starship> results = new List<Starship>();
            var helper = new StarWarsEntityList<Starship>()
            {
                next = url,
                previous = null,
            };

            string jsonResponse = string.Empty;

            while (helper.next != null)
            {
                jsonResponse = GetDataResult(helper.next);
                if (jsonResponse == null)
                {
                    return null;
                }

                helper = JsonConvert.DeserializeObject<StarWarsEntityList<Starship>>(jsonResponse);
                if (helper == null)
                {
                    return null;
                }

                results = results.Union(helper.results);

                if (results.Count() >= size)
                {
                    return results.Take(size).ToList();
                }
            }

            return results.ToList();
        }

    }
}
