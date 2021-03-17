using _5951071124_NguyenHoangVuong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071124_NguyenHoangVuong.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherInfList = new List<WeatherInfo>();
            for(int i = 0; i < 10; i++)
            {
                var WeatherInfo = new WeatherInfo
                {
                    Location = $"Location{i}",
                    Degree = i * 24 / 17,
                    Datetime = DateTime.Now.ToUniversalTime()
                };
                weatherInfList.Add(WeatherInfo);
            }
            return weatherInfList;
        }

        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo
            {
                Location = $"Location{id}",
                Degree = id * 24 / 17,
                Datetime = DateTime.Now.ToUniversalTime()
            };
        }

        // POST: api/Weather
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Weather/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Weather/5
        public void Delete(int id)
        {
        }
    }
}
