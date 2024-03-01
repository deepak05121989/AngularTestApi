using AngularTestApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore;
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
        private readonly TestDBContext _dbContext;
        public MediaItemController(TestDBContext testDBContext) 
        {
            _dbContext = testDBContext;
        }
        // GET: api/<MediaItemController>
        [HttpGet]
        public ActionResult Get()
        {
            List<MediaItem> list = new List<MediaItem>();
            list=_dbContext.MediaItems.ToList();
           // string result=JsonConvert.SerializeObject(list);
            return Ok(list); ;
        }

        // GET api/<MediaItemController>/5
        [HttpGet("{medium}")]
        public ActionResult Get(string medium)
        {
            List<MediaItem> list = new List<MediaItem>();
            list = _dbContext.MediaItems.Where(x=>x.Medium==medium).ToList();

            return Ok(list);
        }

        // POST api/<MediaItemController>
        [HttpPost]
        public void Post(MediaItem mediaItem)
        {

            _dbContext.MediaItems.Add(mediaItem);
            _dbContext.SaveChanges();

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
            var mediaItem = _dbContext.MediaItems.Find(id);
            _dbContext.MediaItems.Remove(mediaItem!);
            _dbContext.SaveChanges();
        }
    }
}
