#pragma warning disable CS8618
using IBAN_Check.Model;
using Newtonsoft.Json;
using RestSharp;

namespace IBAN_Check.Helpers
{
    public class IBANHelper
    {
        private static string API_KEY = "5hpo9Q5Icb7T874iS1uzs6RlsVi9Pa9u";
        private static string BASE_URL = $"https://api.apilayer.com/bank_data/iban_validate?iban_number={0}";

        public static IBAN FetchData(string IBAN)
        {
            var client = new RestClient($"https://api.apilayer.com/bank_data/iban_validate?iban_number={IBAN}");

            var request = new RestRequest();

            request.AddHeader("apikey",API_KEY);

            RestResponse response = client.Execute(request);

            var JsonResult = response.Content;

            var result = JsonConvert.DeserializeObject<IBAN>(JsonResult!);

            if(result != null)
            {
                return result;
            }

            return null!;
        }
    }


    
}
