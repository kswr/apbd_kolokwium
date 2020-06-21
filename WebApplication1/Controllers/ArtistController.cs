using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ArtistController
    {
        [Microsoft.AspNetCore.Components.Route(("api/artists"))]
        [ApiController]
        public class MusiciansController : ControllerBase
        {
            private readonly IArtistService _service;

            public MusiciansController(IArtistService service)
            {
                _service = service;
            }

            [HttpGet("{id}")]
            public IActionResult GetMusician(int id)
            {
                var musician = _service.GetArtist(id);
                if (musician == null)
                {
                    return NotFound();
                }
                return Ok(musician);
            }
        }
    }
}