namespace RepositoryLayer.Migrations
{
    using DomainLayer.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RepositoryLayer.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepositoryLayer.MyDbContext context)
        {

            // write your code here to add intial data

            var products = new List<User>
            {
            new User{UserName="Carson",EmailAddress="Alexander@gmail.com", Password = "fgtrr767"},
            new User{UserName="Meredith",EmailAddress="Alonso@gmail.com", Password = "fgtrr767"},
            new User{UserName="Arturo",EmailAddress="Anand@gmail.com", Password = "fgtrr767"},
            new User{UserName="Gytis",EmailAddress="Barzdukas@gmail.com", Password = "fgtrr767"},
            new User{UserName="Yan",EmailAddress="Li@gmail.com", Password = "fgtrr767"},
            new User{UserName="Peggy",EmailAddress="Justice@gmail.com", Password = "fgtrr767"},
            new User{UserName="Laura",EmailAddress="Norman@gmail.com", Password = "fgtrr767"},
            new User{UserName="Nino",EmailAddress="Olivetto@gmail.com", Password = "fgtrr767"}
            };


            products.ForEach(product => context.User.Add(product));
            context.SaveChanges();
        }
    }
}
