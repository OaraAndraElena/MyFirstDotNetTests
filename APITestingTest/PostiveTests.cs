using System.Net;
using System.Text.RegularExpressions;
using APIinteractions;
using APITestingTest.Helpers;

namespace APITestingTest
{
    [TestFixture]
    public class PositiveTests
    {
        private APIOperations ApiClient;
        private PetData PetData;

        [SetUp]
        public void Setup()
        {
            ApiClient = new APIOperations("https://petstore.swagger.io/v2");
            PetData = PetDataHelper.ReadPetDataFromRelativePath("TestData/PetData.json");
        }

        [Test]
        public void CreatePet()
        {
        
            string requestBody = PetDataHelper.ReadPetJsonFromRelativePath("TestData/PetData.json");
            var response = ApiClient.Create(requestBody);

            //Check that status code is successful
           
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            //Check that response content is correct

            Assert.AreEqual(Regex.Replace(requestBody, @"\s+", string.Empty), response.Content);

        }

        [Test]
        public void ReadPet()
        {
            //Get the created pet by id
            var response = ApiClient.Read(PetData.Id);

            //Check that status code is successful
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }

        [Test]
        public void UpdatePet()
        {
            //Update pet

            string requestBodyUpdate = PetDataHelper.ReadPetJsonFromRelativePath("TestData/PetDataUpdated.json");
            var response = ApiClient.Update(requestBodyUpdate);

            //Check that status code is successful
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }

        [Test]
        public void DeletePet()
        {
            //Delete pat
            var response = ApiClient.Delete(PetData.Id);

            //Check that status code is successful
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
