using Hayp.Server.Connections;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using scrap.Model;
using Hayp.Server.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hayp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScrapController : ControllerBase
    {
        private readonly MongoDbContext _context;
        

        public ScrapController(MongoDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<AllModels>> GetAllModels()
        {
            var allModels = new AllModels
            {
                ModeloCpus = await _context.ModeloCpus.Find(d => true).ToListAsync(),
                ModeloGpus = await _context.ModeloGpus.Find(d => true).ToListAsync(),
                ModeloCases = await _context.ModeloCases.Find(d => true).ToListAsync(),
                ModeloCoolers = await _context.ModeloCoolers.Find(d => true).ToListAsync(),
                ModeloMonitors = await _context.ModeloMonitors.Find(d => true).ToListAsync(),
                ModeloPlacas = await _context.ModeloPlaca.Find(d => true).ToListAsync(),
                ModeloPsus = await _context.ModeloPsus.Find(d => true).ToListAsync(),
                ModelosSsds = await _context.ModelosSsds.Find(d => true).ToListAsync()
            };
            return allModels;
        }
    }
}
