using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using APIQuery.Models;

namespace APIQuery.Controllers
{
    public class CharacterListController : ApiController
    {
        private const string API_URL = "https://census.daybreakgames.com/get/ps2:v2/character/"; 

        public CharacterRoot QueryPS2API_Name (string charName)
        {

            CharacterRoot character = new CharacterRoot();
            string urlParams = "?name.first=" + charName;
            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API_URL);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(urlParams).Result;

            if (response.IsSuccessStatusCode)
            {
                character = response.Content.ReadAsAsync<CharacterRoot>().Result;
            } 
            else
            {
                Console.WriteLine("{0} ({1})", (int) response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();

            return character;
        }

        [Route("api/characterlist/{name}")]
        [HttpGet]
        public IHttpActionResult GetCharacter_Name(string name)
        {
            var character = QueryPS2API_Name(name);

            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }
    }
}
