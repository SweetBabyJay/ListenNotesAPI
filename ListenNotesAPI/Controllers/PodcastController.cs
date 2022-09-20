using System.Reflection;
using System.Text;
using System.Text.Json;
using ListenNotesAPI.Domain.Models;
using ListenNotesAPI.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListenNotesAPI.Controllers
{
    [ApiController]
    public class PodcastController : ControllerBase
    {

        private readonly IRepoWrap _dbcontext;

        public PodcastController(IRepoWrap context)
        {
            _dbcontext = context;
        }

        [Route("podcasts")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PodcastModel>>> Get() { 
            
            
            var podcasts = _dbcontext.Podcasts.GetAll().Result;
            return Ok(podcasts);

        }
        [Route("podcasts/save")]
        public void Save()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sample-api-response.json");
            var file = System.IO.File.ReadAllText(path);

            dynamic result = JsonConvert.DeserializeObject(file);

            foreach(var podcast in result.podcasts)            
            {
                    PodcastModel model = JsonConvert.DeserializeObject<PodcastModel>(podcast.ToString());
                    foreach (int id in model.Genre_Ids)
                    {
                        model.Genres.Add(new GenreModel(id));
                    }
                    
                    _dbcontext.Podcasts.Save(model);
            }
        }
    }
}
