using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            IEnumerable<TopSpot> jsonInfo;
            using (StreamReader r = new StreamReader(@"C:\dev\11-TopSpotsAPI\topspots.json"))
            {
                string json = r.ReadToEnd();
                jsonInfo = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(json);
            }

            return jsonInfo;
        }

        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpots
        public TopSpot Post(TopSpot spot)
        {
            string newJson;
            using (var r = new StreamReader(@"C:\dev\11-TopSpotsAPI\topspots.json"))
            {
                var json = r.ReadToEnd();
                var newSpots = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(json);

                //Add to TopSpot
                var newList = new List<TopSpot>(newSpots) { spot };

                //Save newList back to TopSpot array
                newJson = JsonConvert.SerializeObject(newList);

            }
            // Write newJson file
            using (var sw = new StreamWriter(@"C:\dev\topspots.json"))
            {
                sw.Write(newJson);
            }
            return spot;
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
