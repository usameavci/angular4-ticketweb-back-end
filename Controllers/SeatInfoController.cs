using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Json;
using ticketapi.Models;
using ticketapi.Interfaces;

namespace ticketapi.Controllers
{
    [Route("api/seat/info")]
    public class SeatInfoController : Controller
    {
        private readonly ISeatInfoRepository _seatInfoRepository;

        public SeatInfoController(ISeatInfoRepository seatInfoRepository){
            this._seatInfoRepository = seatInfoRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<SeatInfo> Get()
        {
            return _seatInfoRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
