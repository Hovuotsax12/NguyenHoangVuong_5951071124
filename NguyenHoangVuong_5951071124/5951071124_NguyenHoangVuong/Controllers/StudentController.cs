using System;
using _5951071124_NguyenHoangVuong.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071124_NguyenHoangVuong.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Studen
        List<String> studentInfList = new List<String>();
        public IEnumerable<String> Get()
        {
            studentInfList.Add("Nguyễn Hoàng Vương");
            studentInfList.Add("5951071124");
            studentInfList.Add("Công nghệ thông tin");
            studentInfList.Add("12-04-2000");
            studentInfList.Add("Quảng Ngãi");
            return studentInfList;
        }

        // GET: api/Studen/5
        public String Get(int id)
        {
            studentInfList.Add("Nguyễn Hoàng Vương");
            studentInfList.Add("5951071124");
            studentInfList.Add("Công nghệ thông tin");
            studentInfList.Add("12-04-2000");
            studentInfList.Add("Quảng Ngãi");
            return studentInfList[id].Trim();
        }

        // POST: api/Studen
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Studen/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Studen/5
        public void Delete(int id)
        {
        }
    }
}
