using RestSharp;

namespace APIinteractions
{
    public class APIOperations : APIBase
    {
        public APIOperations(string baseUrl) : base(baseUrl) { }

        //CRUD OPERATIONS
        public RestResponse Create( string newUserJson)
        {
            var request = new RestRequest("/pet", Method.Post);
            request.AddJsonBody(newUserJson);
            return ExecuteRequest(request);
        }

        public RestResponse Read(int petId)
        {
            var request = new RestRequest($"/pet/{petId}", Method.Get);
            return ExecuteRequest(request);
        }

        public RestResponse Update(string updatedPetData)
        {
            var request = new RestRequest("/pet", Method.Put);
            request.AddJsonBody(updatedPetData);
            return ExecuteRequest(request);
        }

        public RestResponse Delete(int petId)
        {
            var request = new RestRequest($"/pet/{petId}", Method.Delete);
            return ExecuteRequest(request);
        }
    }

}

