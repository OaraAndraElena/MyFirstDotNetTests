using RestSharp;

namespace APIinteractions
{


    public class APIBase
    {
        protected RestClient Client;

        public APIBase(string baseUrl)
        {
            Client = new RestClient(baseUrl);
        }

        protected RestResponse ExecuteRequest(RestRequest request)
        {
            return Client.Execute(request);
        }
    }
}