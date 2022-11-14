using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Zoo.Manager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Route betyder at den tager navnet fra controlleren, dvs "Animals, dvs route/Animals
    //  på seleve Sweak siden man man ændre et andet navn
    // man kan eksempelvis æ


    public class AnimalsController : ControllerBase

    {
        //public IEnumerable<FilterItem> GetWithFilter([FromQuery] FilterItem filter)


        //[HttpOptions]



        // Brug IAnimal fra manager

        private IAnimals agr = new AnimalManager();

        // GET: api/<Animals>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        
        public IActionResult Get()
        {
            String rangeValue = Request.Headers["Range"];
            if (rangeValue == null)
            {
                List<Animal> list = agr.Get();
                return (list.Count == 0) ? NoContent() : Ok(list);
            }

            String[] values = rangeValue.Split("-");
            int lowIx = int.Parse(values[0]);
            int highIx = int.Parse(values[1]);

            IEnumerable<Animal> list2 = agr.GetRange(lowIx, highIx);

            Response.Headers.Add("Content-Range", $"{lowIx}-{highIx}/*");

            return Ok(list2);

        }
        // GET api/<Animals>/5
        [HttpGet]
        [Route("{navn}")] // URI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(String navn)
        {
            try
            {
                Animal animal = agr.Get(navn);
                return Ok(animal);
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        // POST api/<Animals>
        [HttpPost]
        [Route("gender/{genderl}")] // URI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetModel(String gender)
        {
            Animal animal = agr.GetGender(gender);

            return (gender.Length > 0) ? Ok(gender) : NoContent();
        }


        // PUT api/<Animals>/5
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult Post([FromBody] Animal animal)
        {
            try
            {
                Animal nyAnimal = agr.Create(animal);
                String uri = "api/Animals/" + animal.Navn;
                return Created(uri, animal);
            }
            catch (ArgumentException ae)
            {
                return Conflict(ae.Message);
            }

        }

        // PUT api/<BilerController>/5
        [HttpPut]
        [Route("{navn}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(string navn, [FromBody] Animal animal)
        {
            try
            {
                return Ok(agr.Update(navn, animal));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }

        }

        [HttpGet]
        [HttpGet]
        [Route("search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get([FromQuery] Item filter)

        {
            {
                List<Animal> liste = agr.SearchQuanity(filter.LowerQuantity, filter.HighQuantity);
                return (liste.Count == 0) ? NoContent() : Ok(liste);
            }
        }
    }





}
