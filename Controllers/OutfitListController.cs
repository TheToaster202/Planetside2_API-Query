using APIQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace APIQuery.Controllers
{
    public class OutfitListController : ApiController
    {
        private const string API_URL = "https://census.daybreakgames.com/get/ps2/outfit/";

        public OutfitListRoot QueryPS2API_OnlineMembers()
        {
            OutfitListRoot onlineMembers = new OutfitListRoot();
            string urlParams = "?alias_lower=wtac&c:show=name,outfit_id&c:join=outfit_member^inject_at:members^show:character_id%27rank^outer:0^list:1(character^inject_at:character^outer:0^on:character_id(characters_online_status^inject_at:online_status^show:online_status^outer:0(world^on:online_status^to:world_id^outer:0^show:world_id))";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API_URL);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(urlParams).Result;

            if (response.IsSuccessStatusCode)
            {
                onlineMembers = response.Content.ReadAsAsync<OutfitListRoot>().Result;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();
            return onlineMembers;

        }

        [Route("api/outfitlist/")]
        [HttpGet]
        public IHttpActionResult GetOnlineMembers()
        {
            var memebers = QueryPS2API_OnlineMembers();

            if (memebers == null)
            {
                return NotFound();
            }

            return Ok(memebers);
        }
    }
}
