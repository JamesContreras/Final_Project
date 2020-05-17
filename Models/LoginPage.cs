using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class LoginPage
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class LoginDBContext : DbContext
    {

    }
}
