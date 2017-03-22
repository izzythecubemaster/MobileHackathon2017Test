using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQLite;
using SQLitePCL;

namespace MobileHackathon2017.Models
{
    public class VisitorLog
    {
        [PrimaryKey]
        public int DLID { get; set; }
        [MaxLength(9)]
        public DateTime TimeIn { get; set; }
        public String Name { get; set; }
        public String TimeOut { get; set; }
    }
}