using System.IO;
using RestSharp;
using Newtonsoft.Json;


namespace SpecFlowDemo
{
    class restApi
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseUrl = "https://reqres.in/";

        //Creating Client Connection
        public static RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            return client = new RestClient(url);
        }

        //Creating request to Get data from server
        public static RestRequest CreateGetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");

            return restRequest;
        }

        //Creating Request to Post data from server
        public static RestRequest CreateRequest(string jsonString)
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", jsonString, ParameterType.RequestBody);
            return restRequest;
        }

        //Executing request to server and checking server response
        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }

        //Extracting output data from received response
        public static DTO GetContent<DTO>(IRestResponse response)
        {
            var content = response.Content;
            DTO deserializeObject = JsonConvert.DeserializeObject<DTO>(content);
            return deserializeObject;
        }
    }
}
