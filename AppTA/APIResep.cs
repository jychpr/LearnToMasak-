using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace AppTA
{
    class APIResep
    {
        public static string GetResep(string food)
        {
            var client = new RestClient("https://www.food2fork.com/");
            var request = new RestRequest($"api/search?key={API key}&q={food}", Method.GET);
            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonArray recipes = (JsonArray)obj["recipes"];
            JsonObject rIdJson = (JsonObject)recipes[0];
            string id = (string)rIdJson[4];

            return id;
        }

        public static List<string> GetBahan(string food)
        {
            string id = GetResep(food);
            List<string> ingredientsList = new List<string>();
            var client = new RestClient("https://www.food2fork.com/");
            var request = new RestRequest($"api/get?key={API key}&rId={id}", Method.GET);
            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject recipes = (JsonObject)obj["recipe"];
            JsonArray ingredients = (JsonArray)recipes["ingredients"];
            foreach(string ingredient in ingredients)
            {
                ingredientsList.Add(ingredient);
            }

            return ingredientsList;
        }
    }
}
