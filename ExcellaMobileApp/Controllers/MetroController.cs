using ExcellaMobileApp.Helper;
using ExcellaMobileApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ExcellaMobileApp.Controllers
{
    public class MetroController : ApiController
    {
        // GET: api/Metro
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Metro/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Metro

      //  [BindJson(typeof(Criteria), "json")]
        public async Task<HttpResponseMessage> Post(Criteria json)
        {

            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("api_key", "d247804d4a6e48b4aeb5c81a44aa9821");

            // Request parameters
            queryString["Lat"] = json.Latitude;
            queryString["Lon"] = json.Longitude;
            queryString["Radius"] = json.radius;



            var uri = "https://api.wmata.com/Rail.svc/StationEntrances?Lat=" + json.Latitude + "&Lon=" + json.Longitude + "&radius=" + json.radius + "&api_key=d247804d4a6e48b4aeb5c81a44aa9821";
           // var uri = "https://api.wmata.com/Rail.svc/StationEntrances&" + queryString;

          

            var response = await client.GetAsync(uri);

            return Request.CreateResponse(HttpStatusCode.OK, response);





        }

        // PUT: api/Metro/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Metro/5
        public void Delete(int id)
        {
        }
    }
}
