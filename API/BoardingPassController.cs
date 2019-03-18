using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Enums;
using API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API
{
  [Route("api/[controller]")]
  [ApiController]
  public class BoardingPassController : ControllerBase
  {
    // GET: api/<controller>
    //[HttpGet]
    //public IEnumerable<string> Get => new string[] { "value1", "value2" };

    //// GET api/<controller>/5
    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //  return "value";
    //}

    // POST api/<controller>
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/<controller>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }

    [HttpGet("{id}")]
    public ActionResult<BoardingPass> Get(string id)
    {
      if (id == "bp-12345")
      {
        return new BoardingPass()
        {
          MovingTxt = "It's go time.",
          BoardingTime = "8:20 PM",
          DepartureGate = "B79",
          Departure = "SFO",
          Arrival = "LAX",
          Term = "1",
          ArraivalGate = "A5",
          Seat = "5A",
          Depart = DepartStatusEnum.ON_TIME,
          Status = StatusEnum.On_Time
        };
      }
      return null;
    }
  }
}
