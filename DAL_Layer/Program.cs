using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirstLogin.Models;
using System.Web.UI;

namespace CodeFirstLogin.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {

        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{UserName="Carson",EmailAddress="Alexander@gmail.com", Password = "fgtrr767"},
            new Student{UserName="Meredith",EmailAddress="Alonso@gmail.com", Password = "fgtrr767"},
            new Student{UserName="Arturo",EmailAddress="Anand@gmail.com", Password = "fgtrr767"},
            new Student{UserName="Gytis",EmailAddress="Barzdukas@gmail.com", Password = "fgtrr767"},
            new Student{UserName="Yan",EmailAddress="Li@gmail.com", Password = "fgtrr767"},
            new Student{UserName="Peggy",EmailAddress="Justice@gmail.com", Password = "fgtrr767"},
            new Student{UserName="Laura",EmailAddress="Norman@gmail.com", Password = "fgtrr767"},
            new Student{UserName="Nino",EmailAddress="Olivetto@gmail.com", Password = "fgtrr767"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }

    }

}