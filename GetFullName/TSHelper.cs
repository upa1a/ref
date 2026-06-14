using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

public class TSHelper
{
    public async Task<string> GetFullNameAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "http://localhost:4444/TransferSimulator/fullName";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    throw new Exception("500");
                }

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("API_ERROR");
                }

                string json = await response.Content.ReadAsStringAsync();

                var obj = JObject.Parse(json);

                string fullName = obj["value"].ToString();

                return fullName;
            }
            catch (HttpRequestException)
            {
                throw new Exception("CONNECTION_ERROR");
            }
        }
    }
}