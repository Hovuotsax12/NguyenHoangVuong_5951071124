using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071124_NguyenHoangVuong.Models
{
    [DataContract]

    public class StudentInfo
    {
        [DataMember(Name = "Ten")]
        public string Name { get; set; }
        [DataMember(Name = "MSSV")]
        public string MSSV { get; set; }
        [DataMember(Name = "NganhHoc")]
        public string NganhHoc { get; set; }
        [DataMember(Name = "NgaySinh")]
        public string NgaySinh { get; set; }
        [DataMember(Name = "QueQuan")]
        public string QueQuan { get; set; }
    }
}