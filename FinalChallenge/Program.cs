using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var bestStudentEver = new Student() { FirstName = "Shaelynn" };

                ctx.Students?.Add(bestStudentEver);
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

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
