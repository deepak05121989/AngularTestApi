using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaItemController : ControllerBase
    {
        // GET: api/<MediaItemController>
        [HttpGet]
        public string Get()
        {
            List<MediaItem> list = new List<MediaItem>();
            list.Add(new MediaItem()
            {
                id= 1,
                name= "Firebug",
                medium= "Series",
                category= "Science Fiction",
                year= 2010,
                watchedOn= 1294166565384,
                isFavorite= false

            });
            list.Add(new MediaItem()
            {
                id = 1,
                name = "The Small Tall",
                medium = "Movies",
                category = "Comedy",
                year = 2015,
                watchedOn = 1294166565384,
                isFavorite = false

            });
            list.Add(new MediaItem()
            {
                id = 1,
                name = "The Redemption",
                medium = "Movies",
                category = "Action",
                year = 2016,
                watchedOn = 1457166565384,
                isFavorite = false

            });
            string result=JsonConvert.SerializeObject(list);
            return result;
        }

        // GET api/<MediaItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MediaItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MediaItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MediaItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
