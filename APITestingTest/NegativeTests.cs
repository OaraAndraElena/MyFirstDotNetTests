
using System.Net;
using APIinteractions;

namespace APITestingTest
{
    [TestFixture]
    public class NegativeTests
    {
        private APIOperations _usersApiClient;

        [SetUp]
        public void Setup()
        {
            _usersApiClient = new APIOperations("https://petstore.swagger.io/v2");
        }

        
        //Provide empty request body
        [Test]
        public void CreatePet_Unsuccessful()
        {
            string newUserJson = "";

            var response = _usersApiClient.Create(newUserJson);
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, response.StatusCode);
        }

        //Read pet by invalid id
        [Test]
        public void ReadPet_Unsuccessful()
        {
            var response = _usersApiClient.Read(1111);

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }

        //Provide empty request body
        [Test]
        public void UpdatePet_Unsuccessful()
        {
            string updatedPetData = "";    
            var response = _usersApiClient.Update(updatedPetData);
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, response.StatusCode);
        }

        //Delete pet by invalid id
        [Test]
        public void DeletePet_Unsuccessful()
        {
            var response = _usersApiClient.Delete(1111);
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }

    }
}
