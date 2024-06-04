using Microsoft.AspNetCore.DataProtection;
using Newtonsoft.Json;
using System.Net;
using static System.Net.WebRequestMethods;

namespace _060424_Searching_OMDB_Lab.Models
{
    public class MovieDAL
    {
        public static MovieModel GetMovie(string Title)  
        {

            string url = $"http://www.omdbapi.com/?s={Title}&apikey={Secret.apiKey}";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON); 
            return result;
        }


















        string title = "";
        string url = $"http://www.omdbapi.com/?s=(movieTitle)&apikey=6b4b8130";
    }
}
