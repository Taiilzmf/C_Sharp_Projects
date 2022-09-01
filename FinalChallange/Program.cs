using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

namespace FinalChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var stud = new Student() { FirstName = "Shaelynn" };

                ctx.Students?.Add(stud);
                ctx.SaveChanges();
            }
        }
    }

   

    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
